//
//  SEBController.h
//  Safe Exam Browser
//
//  Created by Daniel R. Schneider on 18.04.11.
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

// Controller for the preferences window, populates it with panes

#import "PreferencesController.h"
#import "PrefsGeneralViewController.h"
#import "PrefsAdvancedViewController.h"

#import "MBPreferencesController.h"



@implementation PreferencesController

- (void)awakeFromNib
{
    // Set the modules for preferences panes
	PrefsGeneralViewController *general = [[PrefsGeneralViewController alloc] initWithNibName:@"PreferencesGeneral" bundle:nil];
	PrefsAdvancedViewController *advanced = [[PrefsAdvancedViewController alloc] initWithNibName:@"PreferencesAdvanced" bundle:nil];
	[[MBPreferencesController sharedController] setModules:[NSArray arrayWithObjects:general, advanced, nil]];
	[general release];
	[advanced release];
    // Set self as the window delegate to be able to stop modal for the preferences window when it's closed
    // will be overridden when the general pane is displayed (loaded from nib)
    if (![[MBPreferencesController sharedController].window delegate]) {
        // Set delegate only if it's not yet set!
        [[MBPreferencesController sharedController].window setDelegate:self];
#ifdef DEBUG
        NSLog(@"Set PreferencesController as delegate for preferences window")
#endif
    }

}

- (void)showPreferences:(id)sender
{
	[[MBPreferencesController sharedController] showWindow:sender];
}

- (BOOL) preferencesAreOpen {
    return [[MBPreferencesController sharedController].window isVisible];
}


- (void)windowWillClose:(NSNotification *)notification
{
    [[NSApplication sharedApplication] stopModal];
    
}


@end
