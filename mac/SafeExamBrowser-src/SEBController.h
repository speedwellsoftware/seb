//
//  SEBController.h
//  Safe Exam Browser
//
//  Created by Daniel R. Schneider on 29.04.10.
//  Copyright (c) 2010-2011 Daniel R. Schneider, ETH Zurich, 
//  Educational Development and Technology (LET), 
//  based on the original idea of Safe Exam Browser 
//  by Stefan Schneider, University of Giessen
//  Project concept: Thomas Piendl, Daniel R. Schneider, 
//  Dirk Bauer, Karsten Burger, Marco Lehre, 
//  Brigitte Schmucki, Oliver Rahs. French localization: Nicolas Dunand
//
//  ``The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in
//  compliance with the License. You may obtain a copy of the License at
//  http://www.mozilla.org/MPL/
//  
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
//  License for the specific language governing rights and limitations
//  under the License.
//  
//  The Original Code is Safe Exam Browser for Mac OS X.
//  
//  The Initial Developer of the Original Code is Daniel R. Schneider.
//  Portions created by Daniel R. Schneider are Copyright 
//  (C) 2010-2011 Daniel R. Schneider, ETH Zurich, Educational Development
//  and Technology (LET), based on the original idea of Safe Exam Browser 
//  by Stefan Schneider, University of Giessen. All Rights Reserved.
//  
//  Contributor(s): ______________________________________.
//

// Main Safe Exam Browser controller class

#import <Cocoa/Cocoa.h>
#import <WebKit/WebKit.h>
#import "PreferencesController.h"
#import "CapView.h"
#import <IOKit/pwr_mgt/IOPMLib.h>

	
@interface SEBController : NSObject <NSWindowDelegate> {
	
    NSArray *runningAppsWhileTerminating;
    NSMutableArray *visibleApps;
	NSMutableArray *capWindows;
	//NSPoint testpoint;
	BOOL f3Pressed;
	BOOL firstStart;
    BOOL quittingMyself;

	NSWindow *browserWindow;
	WebView *webView;
	IBOutlet id preferencesController;
	IBOutlet NSWindow *aboutWindow;
	IBOutlet NSView *passwordView;
	IBOutlet NSSecureTextField *enterPassword;
    IBOutlet NSWindow *enterPasswordDialog;
	
	IOPMAssertionID assertionID1;
	IOPMAssertionID assertionID2;


       
}

- (void) closeAboutWindow;
- (void) coverScreens;
- (void) adjustScreenLocking: (id)sender;
- (void) regainActiveStatus: (id)sender;
- (void) startKioskMode;

- (NSString *) showEnterPasswordDialog: (NSWindow *)window;
- (IBAction) okEnterPassword: (id)sender;
- (IBAction) cancelEnterPassword: (id)sender;

- (IBAction) exitSEB:(id)sender;

- (void) openPreferences:(id)sender;

- (NSData *) generateSHAHash:(NSString*)inputString;

@property(readwrite) BOOL f3Pressed;
@property(readwrite) BOOL quittingMyself;


@end
