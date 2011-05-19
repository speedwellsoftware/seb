/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is responsible for killing processes.  
 *
 * The Initial Developer of the Original Code is ETH Zuerich.
 * Portions created by the Initial Developer are Copyright (C) 2008
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *   Georg Troxler <gtroxler@student.ethz.ch>
 *   Oliver Rahs <rahs@net.ethz.ch>
 *
 * ***** END LICENSE BLOCK ***** */

#include "stdafx.h"
#include "../ErrorMessage.h"



string GetProcessNameFromID(long processID)
{
	string processName;
	PROCESSENTRY32 pe32;
	ZeroMemory(&pe32, sizeof(PROCESSENTRY32));
	pe32.dwSize     = sizeof(PROCESSENTRY32);

	//get_longest_process_name_length(&nProcessNameLength);
	//nProcessNameLength = nProcessNameLength + 3;

	//logg(fp, "Entering GetProcessNameFromID()\n");
	//logg(fp, "processID = %d\n", processID);

	HANDLE hProcSnapShot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS,0);

	if (Process32First(hProcSnapShot, &pe32) == TRUE)
	{
		//logg(fp, "pe32.th32ProcessID = %d\t", pe32.th32ProcessID);
		//logg(fp, "Process32First(hProcSnapShot, &pe32) == TRUE\n");

		if (pe32.th32ProcessID == processID)
		{
			CloseHandle(hProcSnapShot);
			processName = pe32.szExeFile;
			//logg(fp, "pe32.th32ProcessID == processID\n");
			//logg(fp, "pe32.szExeFile = %s\n", pe32.szExeFile);
			//logg(fp, "processName    = %s\n", processName.c_str());
			//logg(fp, "Leaving GetProcessNameFromID()\n");
			return processName;
		}

		while (Process32Next(hProcSnapShot, &pe32) == TRUE)
		{
			//logg(fp, "pe32.th32ProcessID = %d\t", pe32.th32ProcessID);
			//logg(fp, "Process32Next(hProcSnapShot, &pe32) == TRUE\n");

			if (pe32.th32ProcessID == processID)
			{
				CloseHandle(hProcSnapShot);
				processName = pe32.szExeFile;
				//logg(fp, "pe32.th32ProcessID == processID\n");
				//logg(fp, "pe32.szExeFile = %s\n", pe32.szExeFile);
				//logg(fp, "processName    = %s\n", processName.c_str());
				//logg(fp, "Leaving GetProcessNameFromID()\n");
				return processName;
			}
		}

	} // end if (Process32First(hProcSnapShot,&pe32) == TRUE)

	CloseHandle(hProcSnapShot);
	processName = "";
	//logg(fp, "Process name not found???\n");
	//logg(fp, "pe32.szExeFile = %s\n", pe32.szExeFile);
	//logg(fp, "processName    = %s\n", processName.c_str());
	//logg(fp, "Leaving GetProcessNameFromID()\n");
	return processName;
}



void KILL_PROC_BY_ID(const long procID)
{
	HANDLE hProc;
	string procName;
	
	//string s = GetProcessNameFromID(procID);
	//ofstream stream;
	//stream.open("C:\\Temp\\log.txt",ios_base::app);
	//stream << s << "\n";
	//stream.close();

	procName = GetProcessNameFromID(procID);
	logg(fp, "Entering KILL_PROC_BY_ID(%d)\n", procID);
	logg(fp, "procID   = %d\t", procID);
	logg(fp, "procName = %s\n", procName.c_str());
	hProc = OpenProcess(PROCESS_TERMINATE, FALSE, procID);
	TerminateProcess(hProc, 0);
	logg(fp, "Leaving  KILL_PROC_BY_ID(%d)\n", procID);
}

/* Method created: 6/23/2000  (RK)
Last modified: 3/10/2002  (RK)
Please report any problems or bugs to kochhar@physiology.wisc.edu
The latest version of this routine can be found at:
    http://www.neurophys.wisc.edu/ravi/software/killproc/
Terminate the process "szToTerminate" if it is currently running
This works for Win/95/98/ME and also Win/NT/2000/XP
The process name is case-insensitive, i.e. "notepad.exe" and "NOTEPAD.EXE"
will both work (for szToTerminate)
Return codes are as follows:
  0   = Process was successfully terminated
  603 = Process was not currently running
  604 = No permission to terminate process
  605 = Unable to load PSAPI.DLL
  602 = Unable to terminate process for some other reason
  606 = Unable to identify system type
  607 = Unsupported OS
  632 = Invalid process name
  700 = Unable to get procedure address from PSAPI.DLL
  701 = Unable to get process list, EnumProcesses failed
  702 = Unable to load KERNEL32.DLL
  703 = Unable to get procedure address from KERNEL32.DLL
  704 = CreateToolhelp32Snapshot failed
Change history:
  modified 3/8/2002  - Borland-C compatible if BORLANDC is defined as
                       suggested by Bob Christensen
  modified 3/10/2002 - Removed memory leaks as suggested by
				      Jonathan Richard-Brochu (handles to Proc and Snapshot
                       were not getting closed properly in some cases)
*/



int KILL_PROC_BY_NAME(const char *szToTerminate)
// Created: 6/23/2000  (RK)
// Last modified: 3/10/2002  (RK)
// Please report any problems or bugs to kochhar@physiology.wisc.edu
// The latest version of this routine can be found at:
//     http://www.neurophys.wisc.edu/ravi/software/killproc/
// Terminate the process "szToTerminate" if it is currently running
// This works for Win/95/98/ME and also Win/NT/2000/XP
// The process name is case-insensitive, i.e. "notepad.exe" and "NOTEPAD.EXE"
// will both work (for szToTerminate)
// Return codes are as follows:
//   0   = Process was successfully terminated
//   603 = Process was not currently running
//   604 = No permission to terminate process
//   605 = Unable to load PSAPI.DLL
//   602 = Unable to terminate process for some other reason
//   606 = Unable to identify system type
//   607 = Unsupported OS
//   632 = Invalid process name
//   700 = Unable to get procedure address from PSAPI.DLL
//   701 = Unable to get process list, EnumProcesses failed
//   702 = Unable to load KERNEL32.DLL
//   703 = Unable to get procedure address from KERNEL32.DLL
//   704 = CreateToolhelp32Snapshot failed
// Change history:
//   modified 3/8/2002  - Borland-C compatible if BORLANDC is defined as
//                        suggested by Bob Christensen
//   modified 3/10/2002 - Removed memory leaks as suggested by
//					      Jonathan Richard-Brochu (handles to Proc and Snapshot
//                        were not getting closed properly in some cases)
{
	BOOL bResult,bResultm;
	DWORD aiPID[1000], iCb=1000, iNumProc, iV2000=0;
	DWORD iCbneeded, i, iFound=0;
	string procName;
	char szName[MAX_PATH], szToTermUpper[MAX_PATH];
	HANDLE hProc,hSnapShot,hSnapShotm;
	OSVERSIONINFO osvi;
    HINSTANCE hInstLib;
	int iLen, iLenP, indx;
    HMODULE hMod;
	PROCESSENTRY32 procentry;      
	MODULEENTRY32   modentry;

	procName = (string)szToTerminate;
	logg(fp, "Entering KILL_PROC_BY_NAME(%s)\n", szToTerminate);
	logg(fp, "procName = %s\n", procName.c_str());

	// Transfer Process name into "szToTermUpper" and
	// convert it to upper case
	iLenP = strlen(szToTerminate);
	if (iLenP < 1 || iLenP > MAX_PATH) return 632;
	for (indx = 0; indx < iLenP; indx++)
		szToTermUpper[indx] = toupper(szToTerminate[indx]);
	szToTermUpper[iLenP] = 0;

	// PSAPI Function Pointers.
	BOOL  (WINAPI *lpfEnumProcesses     )(DWORD*, DWORD cb, DWORD *);
	BOOL  (WINAPI *lpfEnumProcessModules)(HANDLE, HMODULE*, DWORD , LPDWORD);
	DWORD (WINAPI *lpfGetModuleBaseName )(HANDLE, HMODULE , LPTSTR,   DWORD);

	// ToolHelp Function Pointers.
	HANDLE (WINAPI *lpfCreateToolhelp32Snapshot)(DWORD,DWORD)   ;
	BOOL   (WINAPI *lpfProcess32First)(HANDLE,LPPROCESSENTRY32) ;
	BOOL   (WINAPI *lpfProcess32Next )(HANDLE,LPPROCESSENTRY32) ;
	BOOL   (WINAPI *lpfModule32First )(HANDLE,LPMODULEENTRY32 ) ;
	BOOL   (WINAPI *lpfModule32Next  )(HANDLE,LPMODULEENTRY32 ) ;

	// First check what version of Windows we're in
	osvi.dwOSVersionInfoSize = sizeof(OSVERSIONINFO);
    bResult = GetVersionEx(&osvi);
	if (!bResult)     // Unable to identify system version
		return 606;

	// At Present we only support Win/NT/2000/XP or Win/9x/ME
	if ((osvi.dwPlatformId != VER_PLATFORM_WIN32_NT) &&
		(osvi.dwPlatformId != VER_PLATFORM_WIN32_WINDOWS))
		return 607;

    if (osvi.dwPlatformId == VER_PLATFORM_WIN32_NT)
	{
		// Win/NT or 2000 or XP

		// Load library and get the procedures explicitly. We do
		// this so that we don't have to worry about modules using
		// this code failing to load under Windows 9x, because
		// it can't resolve references to the PSAPI.DLL.
		hInstLib = LoadLibraryA("PSAPI.DLL");
		if (hInstLib == NULL)
			return 605;

		// Get procedure addresses.
		lpfEnumProcesses = (BOOL(WINAPI *)(DWORD *,DWORD,DWORD*))
			GetProcAddress( hInstLib, "EnumProcesses" ) ;
		lpfEnumProcessModules = (BOOL(WINAPI *)(HANDLE, HMODULE *,
			DWORD, LPDWORD)) GetProcAddress( hInstLib,
			"EnumProcessModules" ) ;
		lpfGetModuleBaseName = (DWORD (WINAPI *)(HANDLE, HMODULE,
			LPTSTR, DWORD )) GetProcAddress( hInstLib,
			"GetModuleBaseNameA" ) ;

		if (lpfEnumProcesses      == NULL ||
			lpfEnumProcessModules == NULL ||
			lpfGetModuleBaseName  == NULL)
		{
			FreeLibrary(hInstLib);
			return 700;
		}
		 
		bResult = lpfEnumProcesses(aiPID, iCb, &iCbneeded);
		if (!bResult)
		{
			// Unable to get process list, EnumProcesses failed
            FreeLibrary(hInstLib);
			return 701;
		}

		// How many processes are there?
		iNumProc = iCbneeded / sizeof(DWORD);

		// Get and match the name of each process
		for (i = 0; i < iNumProc; i++)
		{
			// Get the (module) name for this process

	        strcpy(szName, "Unknown");
			// First, get a handle to the process
	        hProc = OpenProcess(PROCESS_QUERY_INFORMATION|PROCESS_VM_READ, FALSE, aiPID[i]);
	        // Now, get the process name
	        if (hProc)
			{
               if (lpfEnumProcessModules(hProc, &hMod, sizeof(hMod), &iCbneeded))
			   {
					iLen = lpfGetModuleBaseName(hProc, hMod, szName, MAX_PATH);
					logg(fp, "\tszName = %s\n", szName);
			   }
			}
	        CloseHandle(hProc);

			if (strcmp(_strupr(szName), szToTermUpper) == 0)
			{
				// Process found, now terminate it
				iFound = 1;
				// First open for termination
				hProc = OpenProcess(PROCESS_TERMINATE, FALSE, aiPID[i]);
				if (hProc)
				{
					if (TerminateProcess(hProc, 0))
					{
						// process terminated
						CloseHandle(hProc);
                        FreeLibrary(hInstLib);
						return 0;
					}
					else
					{
						// Unable to terminate process
						CloseHandle(hProc);
                        FreeLibrary(hInstLib);
						return 602;
					}
				}
				else
				{
					// Unable to open process for termination
                    FreeLibrary(hInstLib);
					return 604;
				}
			}
		}
	}

	if(osvi.dwPlatformId==VER_PLATFORM_WIN32_WINDOWS)
	{
		// Win/95 or 98 or ME
			
		hInstLib = LoadLibraryA("Kernel32.DLL");
		if (hInstLib == NULL)
			return 702;

		// Get procedure addresses.
		// We are linking to these functions of Kernel32
		// explicitly, because otherwise a module using
		// this code would fail to load under Windows NT,
		// which does not have the Toolhelp32
		// functions in the Kernel 32.
		lpfCreateToolhelp32Snapshot=
			(HANDLE(WINAPI *)(DWORD,DWORD))
			GetProcAddress( hInstLib,
			"CreateToolhelp32Snapshot" ) ;
		lpfProcess32First=
			(BOOL(WINAPI *)(HANDLE,LPPROCESSENTRY32))
			GetProcAddress( hInstLib, "Process32First" ) ;
		lpfProcess32Next=
			(BOOL(WINAPI *)(HANDLE,LPPROCESSENTRY32))
			GetProcAddress( hInstLib, "Process32Next" ) ;
		lpfModule32First=
			(BOOL(WINAPI *)(HANDLE,LPMODULEENTRY32))
			GetProcAddress( hInstLib, "Module32First" ) ;
		lpfModule32Next=
			(BOOL(WINAPI *)(HANDLE,LPMODULEENTRY32))
			GetProcAddress( hInstLib, "Module32Next" ) ;
		if (lpfProcess32Next            == NULL ||
			lpfProcess32First           == NULL ||
		    lpfModule32Next             == NULL ||
			lpfModule32First            == NULL ||
			lpfCreateToolhelp32Snapshot == NULL)
		{
			FreeLibrary(hInstLib);
			return 703;
		}
			
		// The Process32.. and Module32.. routines return names in all uppercase

		// Get a handle to a Toolhelp snapshot of all the systems processes.

		hSnapShot = lpfCreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
		if (hSnapShot == INVALID_HANDLE_VALUE)
		{
			FreeLibrary(hInstLib);
			return 704;
		}
		
        // Get the first process' information.
        procentry.dwSize = sizeof(PROCESSENTRY32);
        bResult = lpfProcess32First(hSnapShot, &procentry);

        // While there are processes, keep looping and checking.
        while (bResult)
        {
		    // Get a handle to a Toolhelp snapshot of this process.
		    hSnapShotm = lpfCreateToolhelp32Snapshot(TH32CS_SNAPMODULE, procentry.th32ProcessID);
		    if (hSnapShotm == INVALID_HANDLE_VALUE)
			{
				CloseHandle(hSnapShot);
			    FreeLibrary(hInstLib);
			    return 704;
			}
			// Get the module list for this process
			modentry.dwSize = sizeof(MODULEENTRY32);
			bResultm=lpfModule32First(hSnapShotm,&modentry);

			// While there are modules, keep looping and checking
			while (bResultm)
			{
				if (strcmp(modentry.szModule,szToTermUpper) == 0)
				{
				    // Process found, now terminate it
				    iFound = 1;
				    // First open for termination
				    hProc = OpenProcess(PROCESS_TERMINATE, FALSE, procentry.th32ProcessID);
				    if (hProc)
					{
					    if (TerminateProcess(hProc, 0))
						{
						    // process terminated
							CloseHandle(hSnapShotm);
							CloseHandle(hSnapShot);
							CloseHandle(hProc);
			                FreeLibrary(hInstLib);
						    return 0;
						}
					    else
						{
						    // Unable to terminate process
							CloseHandle(hSnapShotm);
							CloseHandle(hSnapShot);
							CloseHandle(hProc);
			                FreeLibrary(hInstLib);
						    return 602;
						}
					}
				    else
					{
					    // Unable to open process for termination
						CloseHandle(hSnapShotm);
						CloseHandle(hSnapShot);
			            FreeLibrary(hInstLib);
					    return 604;
					}
				}
				else
				{  // Look for next modules for this process
					modentry.dwSize = sizeof(MODULEENTRY32);
					bResultm = lpfModule32Next(hSnapShotm, &modentry);
				}
			}

			//Keep looking
			CloseHandle(hSnapShotm);
            procentry.dwSize = sizeof(PROCESSENTRY32);
            bResult = lpfProcess32Next(hSnapShot, &procentry);
        }
		CloseHandle(hSnapShot);
	}
	if (iFound == 0)
	{
		FreeLibrary(hInstLib);
		return 603;
	}
	FreeLibrary(hInstLib);
	return 0;
}