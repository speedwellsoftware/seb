﻿//
//  SebMessageBox.cs
//  SafeExamBrowser
//
//  Copyright (c) 2010-2014 Viktor Tomas, Dirk Bauer, Daniel R. Schneider, Pascal Wyss,
//  ETH Zurich, Educational Development and Technology (LET),
//  based on the original idea of Safe Exam Browser
//  by Stefan Schneider, University of Giessen
//  Project concept: Thomas Piendl, Daniel R. Schneider,
//  Dirk Bauer, Kai Reuter, Tobias Halbherr, Karsten Burger, Marco Lehre,
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
//  The Original Code is Safe Exam Browser for Windows.
//
//  The Initial Developers of the Original Code are Viktor Tomas, 
//  Dirk Bauer, Daniel R. Schneider, Pascal Wyss.
//  Portions created by Viktor Tomas, Dirk Bauer, Daniel R. Schneider, Pascal Wyss
//  are Copyright (c) 2010-2014 Viktor Tomas, Dirk Bauer, Daniel R. Schneider, 
//  Pascal Wyss, ETH Zurich, Educational Development and Technology (LET), 
//  based on the original idea of Safe Exam Browser
//  by Stefan Schneider, University of Giessen. All Rights Reserved.
//
//  Contributor(s): ______________________________________.
//

using System;
using System.Windows;

namespace SebShared.Utils
{
    public class SebMessageBox
    {
	    public static event Action BeforeShow = delegate { };

        public static MessageBoxResult Show(string messageTitle, string messageText, MessageBoxImage messageBoxIcon, MessageBoxButton messageButtons)
        {
	        BeforeShow();
	        return MessageBox.Show(messageText, messageTitle, messageButtons, messageBoxIcon);
        }
    }
}
