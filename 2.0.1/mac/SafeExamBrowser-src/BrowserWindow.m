//
//  BrowserWindow.m
//  Safe Exam Browser
//
//  Created by Daniel R. Schneider on 06.12.10.
//  Copyright (c) 2010-2012 Daniel R. Schneider, ETH Zurich, 
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
//  (C) 2010-2012 Daniel R. Schneider, ETH Zurich, Educational Development
//  and Technology (LET), based on the original idea of Safe Exam Browser 
//  by Stefan Schneider, University of Giessen. All Rights Reserved.
//  
//  Contributor(s): ______________________________________.
//

#import "BrowserWindow.h"
#import "MainBrowserWindow.h"
#import "MyGlobals.h"
#import "Constants.h"
#import "MyDocument.h"
#import "NSWindow+SEBWindow.h"


@implementation BrowserWindow


// Setup browser window and webView delegates
- (void) awakeFromNib
{    
	// Suppress right-click with own delegate method for context menu
	[webView setUIDelegate:self];
	
	// The Policy Delegate is needed to catch opening links in new windows
	[webView setPolicyDelegate:self];
	
	// The Frame Load Delegate is needed to monitor frame loads
	[webView setFrameLoadDelegate:self];
    
    // Set group name to group related frames (so not to open several new windows)
    [webView setGroupName:@"MyDocument"];

    // Close webView when the last document window is closed
    [webView setShouldCloseWithWindow:YES];
    
    // Set bindings to web preferences
    WebPreferences *webPrefs = [WebPreferences standardPreferences];
#ifndef __i386__        // Plugins can't be switched on in the 32-bit Intel build
    [webPrefs bind:@"plugInsEnabled"
          toObject:[NSUserDefaultsController sharedUserDefaultsController]
       withKeyPath:@"values.enablePlugins"
           options:nil];
#endif
    [webPrefs bind:@"javaEnabled"
          toObject:[NSUserDefaultsController sharedUserDefaultsController]
       withKeyPath:@"values.enableJava"
           options:nil];
    
    [webPrefs bind:@"javaScriptEnabled"
          toObject:[NSUserDefaultsController sharedUserDefaultsController]
       withKeyPath:@"values.enableJavaScript"
           options:nil];

    NSDictionary *bindingOptions = [NSDictionary dictionaryWithObjectsAndKeys:@"NSNegateBoolean",NSValueTransformerNameBindingOption,nil];
    [webPrefs bind:@"javaScriptCanOpenWindowsAutomatically"
          toObject:[NSUserDefaultsController sharedUserDefaultsController]
       withKeyPath:@"values.blockPopUpWindows"
           options:bindingOptions];
    
    [webView setPreferences:webPrefs];

    [webView bind:@"maintainsBackForwardList"
          toObject:[NSUserDefaultsController sharedUserDefaultsController]
       withKeyPath:@"values.enableBrowsingBackForward"
           options:nil];

    /*/ Add an observer for the request to close this window's document
    [[NSNotificationCenter defaultCenter] addObserver:self
                                             selector:@selector(closeDocument:)
                                                 name:@"requestDocumentClose" 
                                               object:nil];
	*/
/*#ifdef DEBUG
    // Display all MIME types the WebView can display as HTML
    NSArray* MIMETypes = [WebView MIMETypesShownAsHTML];
    int i, count = [MIMETypes count];
    for (i=0; i<count; i++) {
        NSLog(@"MIME type shown as HTML: %@", [MIMETypes objectAtIndex:i]);
    }
#endif*/

}

// Overriding the sendEvent method allows blocking the context menu
// in the whole WebView, even in plugins
- (void)sendEvent:(NSEvent *)theEvent
{
	int controlKeyDown = [theEvent modifierFlags] & NSControlKeyMask;
	// filter out right clicks
	if (!(([theEvent type] == NSLeftMouseDown && controlKeyDown) ||
		[theEvent type] == NSRightMouseDown))
		[super sendEvent:theEvent];
}


// Overriding this method without calling super in OS X 10.7 Lion
// prevents the windows' position and size to be restored on restarting the app
- (void)restoreStateWithCoder:(NSCoder *)coder
{
#ifdef DEBUG
    NSLog(@"BrowserWindow %@: Prevented windows' position and size to be restored!", self);
#endif
    return;
}


/*- (void)closeDocument:(id)sender {
    // Get document for my web view
    id myDocument = [[NSDocumentController sharedDocumentController] documentForWindow:[webView window]];
    // Close document and therefore also window
    //Workaround: Flash crashes after closing window and then clicking some other link
    [[webView preferences] setPlugInsEnabled:NO];
    [webView setPreferences:nil];
    [webView unbind:@"maintainsBackForwardList"];
	// Suppress right-click with own delegate method for context menu
	[webView setUIDelegate:nil];
	
	// The Policy Delegate is needed to catch opening links in new windows
	[webView setPolicyDelegate:nil];
	
	// The Frame Load Delegate is needed to monitor frame loads
	[webView setFrameLoadDelegate:nil];

    [myDocument close];
    // Send notification to switch plugins on again
    [[NSNotificationCenter defaultCenter] postNotificationName:@"switchPluginsOn" object:self];
}
*/    
#pragma mark Delegates

// Delegate method for disabling right-click context menu
- (NSArray *)webView:(WebView *)sender contextMenuItemsForElement:(NSDictionary *)element 
    defaultMenuItems:(NSArray *)defaultMenuItems {
    // disable right-click context menu
    return NO;
}


// Delegate method for JavaScript alert panel
- (void)webView:(WebView *)sender runJavaScriptAlertPanelWithMessage:(NSString *)message 
initiatedByFrame:(WebFrame *)frame {
	NSString *pageTitle = [sender stringByEvaluatingJavaScriptFromString:@"document.title"];
	NSRunAlertPanel(pageTitle, message, NSLocalizedString(@"OK",nil), nil, nil);
}


// Delegate method for JavaScript confirmation panel
- (BOOL)webView:(WebView *)sender runJavaScriptConfirmPanelWithMessage:(NSString *)message 
initiatedByFrame:(WebFrame *)frame {
	NSString *pageTitle = [sender stringByEvaluatingJavaScriptFromString:@"document.title"];
	return NSRunAlertPanel(pageTitle, message, NSLocalizedString(@"OK",nil), NSLocalizedString(@"Cancel",nil), nil);
}


// Get the URL of the page being loaded
- (void)webView:(WebView *)sender didStartProvisionalLoadForFrame:(WebFrame *)frame {
    // Only report feedback for the main frame.
    if (frame == [sender mainFrame]){
        [[MyGlobals sharedMyGlobals] setCurrentMainHost:[[[[frame provisionalDataSource] request] URL] host]];
        //reset the flag for presentation option changes by flash
        [[MyGlobals sharedMyGlobals] setFlashChangedPresentationOptions:NO];
    }
}


// Update the URL of the current page in case of a server redirect
- (void)webView:(WebView *)sender didReceiveServerRedirectForProvisionalLoadForFrame:(WebFrame *)frame {
    // Only report feedback for the main frame.
    if (frame == [sender mainFrame]){
        [[MyGlobals sharedMyGlobals] setCurrentMainHost:[[[[frame provisionalDataSource] request] URL] host]];
        //reset the flag for presentation option changes by flash
        [[MyGlobals sharedMyGlobals] setFlashChangedPresentationOptions:NO];
    }
}


- (void)webView:(WebView *)sender didReceiveTitle:(NSString *)title forFrame:(WebFrame *)frame
{
    // Report feedback only for the main frame.
    if (frame == [sender mainFrame]){
        NSString* appTitleString = [NSString stringWithFormat:@"Safe Exam Browser %@ • %@", 
                                    [self infoValueForKey:@"CFBundleVersion"], 
                                    title];
        CGFloat windowWidth = [NSWindow minFrameWidthWithTitle:appTitleString styleMask:NSTitledWindowMask|NSClosableWindowMask|NSMiniaturizableWindowMask];
        if (windowWidth > [[sender window] frame].size.width) {
            appTitleString = [NSString stringWithFormat:@"SEB %@ • %@", 
                                        [self infoValueForKey:@"CFBundleVersion"], 
                                        title];
        }
#ifdef DEBUG
        NSLog(@"BrowserWindow %@: Title of current Page: %@", self, appTitleString);
#endif
        [sender.window setTitle:appTitleString];
    }
}


// Read Info.plist values from bundle
- (id) infoValueForKey:(NSString*)key
{
    if ([[[NSBundle mainBundle] localizedInfoDictionary] objectForKey:key])
        return [[[NSBundle mainBundle] localizedInfoDictionary] objectForKey:key];
	
    return [[[NSBundle mainBundle] infoDictionary] objectForKey:key];
}


// Opening Links in New Windows //

// Handling of requests to open a link in a new window (including Javascript commands)
- (WebView *)webView:(WebView *)sender createWebViewWithRequest:(NSURLRequest *)request {
    // Single browser window: [[webView mainFrame] loadRequest:request];
    // Multiple browser windows
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    if ([preferences integerForKey:@"newBrowserWindowByScriptPolicy"] != getGenerallyBlocked) {
        NSApplicationPresentationOptions presentationOptions = [NSApp currentSystemPresentationOptions];
#ifdef DEBUG
        NSLog(@"Current System Presentation Options: %lx",(long)presentationOptions);
        NSLog(@"Saved System Presentation Options: %lx",(long)[[MyGlobals sharedMyGlobals] presentationOptions]);
#endif
        if ((presentationOptions != [[MyGlobals sharedMyGlobals] presentationOptions]) || ([[MyGlobals sharedMyGlobals] flashChangedPresentationOptions])) {
            // request to open link in new window came from the flash plugin context menu while playing video in full screen mode
#ifdef DEBUG
            NSLog(@"Cancel opening link");
#endif
            return nil; // cancel opening link
        }
        if ([preferences integerForKey:@"newBrowserWindowByScriptPolicy"] == openInNewWindow) {
            MyDocument *myDocument = [[NSDocumentController sharedDocumentController] openUntitledDocumentOfType:@"DocumentType" display:YES];
            WebView *newWindowWebView = myDocument.mainWindowController.webView;
#ifdef DEBUG
            NSLog(@"Now opening new document browser window. %@", newWindowWebView); 
            NSLog(@"Reqested from %@",sender); 
#endif
            //[[sender preferences] setPlugInsEnabled:NO];
            [[newWindowWebView mainFrame] loadRequest:request];
            return newWindowWebView;
        }
        if ([preferences integerForKey:@"newBrowserWindowByScriptPolicy"] == openInSameWindow) {
            WebView *tempWebView = [[WebView alloc] init];
            //create a new temporary, invisible WebView
            [tempWebView setPolicyDelegate:self];
            [tempWebView setUIDelegate:self];
            [tempWebView setGroupName:@"MyDocument"];
            [tempWebView setFrameLoadDelegate:self];
            return tempWebView;
        }
        return nil;
    } else {
        return nil;
    }
}


// Handling of requests from web plugins to open a link in a new window 
- (void)webView:(WebView *)sender decidePolicyForNavigationAction:(NSDictionary *)actionInformation 
        request:(NSURLRequest *)request 
          frame:(WebFrame *)frame 
decisionListener:(id <WebPolicyDecisionListener>)listener {

    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    NSString *currentMainHost = [[MyGlobals sharedMyGlobals] currentMainHost];
    if (currentMainHost && [preferences integerForKey:@"newBrowserWindowByScriptPolicy"] == getGenerallyBlocked) {
        [listener ignore];
        return;
    }
    if ([preferences boolForKey:@"newBrowserWindowByScriptBlockForeign"]) {
        NSString *requestedHost = [[request mainDocumentURL] host];
#ifdef DEBUG
        NSLog(@"Current Host: %@", currentMainHost); 
        NSLog(@"Requested Host: %@", requestedHost); 
#endif
        // If current host is not the same as the requested host
        if (currentMainHost && (!requestedHost || ![currentMainHost isEqualToString:requestedHost])) {
            [listener ignore];
            // If the new page is supposed to open in a new browser window
            if (requestedHost && webView && [preferences integerForKey:@"newBrowserWindowByScriptPolicy"] == openInNewWindow) {
                // we have to close the new browser window which already has been openend by WebKit
                // Get the document for my web view
#ifdef DEBUG
                NSLog(@"Originating browser window %@", sender);
#endif
                id myDocument = [[NSDocumentController sharedDocumentController] documentForWindow:[webView window]];
                // Close document and therefore also window
                //Workaround: Flash crashes after closing window and then clicking some other link
                [[webView preferences] setPlugInsEnabled:NO];
#ifdef DEBUG
                NSLog(@"Now closing new document browser window. %@", webView);
#endif
                //[[webView window] orderOut:self];
                /*NSArray *windowControllers = [myDocument windowControllers];
                // Get first window controller
                id  windowController;
                windowController = [windowControllers objectAtIndex:0];
                [myDocument removeWindowController:windowController];
                [windowController close];*/
                //[webView stopLoading:self];
                //[webView close];
                //webView = nil;
                [myDocument close];
                // Send notification to close the document (closing it directly here can cause crashes)
                //[[NSNotificationCenter defaultCenter] postNotificationName:@"closeDocument" object:myDocument];
                // Send notification to switch plugins on again
                //[[NSNotificationCenter defaultCenter] postNotificationName:@"switchPluginsOn" object:self];
            }
            if ([preferences integerForKey:@"newBrowserWindowByScriptPolicy"] == openInSameWindow) {
                if (webView) {
                    [sender close]; //close the temporary webview
                }
            }
            return;
        } 
    }
    // Check if the new page is supposed to be opened in the same browser window
    if (currentMainHost && [preferences integerForKey:@"newBrowserWindowByScriptPolicy"] == openInSameWindow) {
        if (webView && ![sender isEqual:webView]) {
            // If the request's sender is the temporary webview, then we have to load the request now in the current webview
            [listener ignore]; // ignore listener
            [[webView mainFrame] loadRequest:request]; //load the new page in the same browser window
            [sender close]; //close the temporary webview
            return; //and return from here
        }
    }
    // Check if the new page is supposed to be opened in the same browser window
    [listener use];
}


// Open the link requesting to be opened in a new window according to settings
- (void)webView:(WebView *)sender decidePolicyForNewWindowAction:(NSDictionary *)actionInformation 
		request:(NSURLRequest *)request 
   newFrameName:(NSString *)frameName 
decisionListener:(id <WebPolicyDecisionListener>)listener {
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    // First check if links requesting to be opened in a new windows are generally blocked
    if ([preferences integerForKey:@"newBrowserWindowByLinkPolicy"] != getGenerallyBlocked) {
        // load link only if it's on the same host like the one of the current page
        if (![preferences boolForKey:@"newBrowserWindowByLinkBlockForeign"] ||
            [[[MyGlobals sharedMyGlobals] currentMainHost] isEqualToString:[[request mainDocumentURL] host]]) {
            if ([preferences integerForKey:@"newBrowserWindowByLinkPolicy"] == openInNewWindow) {
                // Multiple browser windows
                MyDocument *myDocument = [[NSDocumentController sharedDocumentController] openUntitledDocumentOfType:@"DocumentType" display:YES];
                //WebView *newWindowWebView = myDocument.mainWindowController.webView;
                [myDocument.mainWindowController.window setSharingType: NSWindowSharingNone];  //don't allow other processes to read window contents
                if (![preferences boolForKey:@"allowSwitchToThirdPartyApps"]) {
                    // Order new browser window to the front of our level
                    [myDocument.mainWindowController.window newSetLevel:NSModalPanelWindowLevel];
                }
                [[myDocument.mainWindowController.webView mainFrame] loadRequest:request];
            }
            if ([preferences integerForKey:@"newBrowserWindowByLinkPolicy"] == openInSameWindow) {
                // Single browser window
                [[sender mainFrame] loadRequest:request];
            }
        }
    }
    [listener ignore];
}


// Show new window containing webView
- (void)webViewShow:(WebView *)sender
{
    id myDocument = [[NSDocumentController sharedDocumentController] documentForWindow:[sender window]];
    [[sender window] setSharingType: NSWindowSharingNone];  //don't allow other processes to read window contents
    if (![[NSUserDefaults standardUserDefaults] boolForKey:@"allowSwitchToThirdPartyApps"]) {
        [[sender window] newSetLevel:NSModalPanelWindowLevel];
    }
    [myDocument showWindows];
#ifdef DEBUG
    NSLog(@"Now showing new document browser window. %@",sender); 
#endif
    // Order new browser window to the front
    //[[sender window] makeKeyAndOrderFront:self];
}

/*
- (void)orderOut:(id)sender {
    //we prevent the browser window to be hidden
}
*/

- (NSView*)findFlashViewInView:(NSView*)view 
{
    NSString* className = [view className];
    
    // WebHostedNetscapePluginView showed up in Safari 4.x,
    // WebNetscapePluginDocumentView is Safari 3.x.
    if ([className isEqual:@"WebHostedNetscapePluginView"] ||
        [className isEqual:@"WebNetscapePluginDocumentView"]) 
    {
        // Do any checks to make sure you've got the right player
        return view;
    }
    
    // Okay, this view isn't a plugin, keep going
    for (NSView* subview in [view subviews]) 
    {
        NSView* result = [self findFlashViewInView:subview];
        if (result) return result;
    }
    
    return nil;
}


// Downloading and Uploading of Files //

- (void)webView:(WebView *)sender runOpenPanelForFileButtonWithResultListener:(id < WebOpenPanelResultListener >)resultListener
// Choose file for upload
{
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    if ([preferences boolForKey:@"allowDownUploads"] == YES) {
        if ([preferences integerForKey:@"chooseFileToUploadPolicy"] != manuallyWithFileRequester) {
            // If the policy isn't "manually with file requester"
            // We try to choose the filename and path ourselves, it's the last dowloaded file
            NSInteger lastDownloadPathIndex = [[MyGlobals sharedMyGlobals] lastDownloadPath];
            NSMutableArray *downloadPaths = [[MyGlobals sharedMyGlobals] downloadPath];
            if (downloadPaths && downloadPaths.count) {
                if (lastDownloadPathIndex == -1) {
                    //if the index counter of the last downloaded file is -1, we have reached the beginning of the list of downloaded files
                    lastDownloadPathIndex = [downloadPaths count]-1; //so we jump to the last path in the list
                }
                NSString *lastDownloadPath = [downloadPaths objectAtIndex:lastDownloadPathIndex];
                lastDownloadPathIndex--;
                [[MyGlobals sharedMyGlobals] setLastDownloadPath:lastDownloadPathIndex];
                if (lastDownloadPath && [[NSFileManager defaultManager] fileExistsAtPath:lastDownloadPath]) {
                    [resultListener chooseFilename:lastDownloadPath];
                    NSRunAlertPanel(NSLocalizedString(@"File automatically chosen", nil), 
                                    NSLocalizedString(@"SEB will upload the same file which was downloaded before. If you edited it in a third party application, be sure you have saved it with the same name at the same path.", nil), 
                                    NSLocalizedString(@"OK", nil), nil, nil);
                    return;
                }
            }
            
            if ([preferences integerForKey:@"chooseFileToUploadPolicy"] == onlyAllowUploadSameFileDownloadedBefore) {
                // if the policy is "Only allow to upload the same file downloaded before"
                NSRunAlertPanel(NSLocalizedString(@"File to upload not found!", nil), 
                                NSLocalizedString(@"SEB is configured to only allow to upload a file which was downloaded before. So download a file and if you edit it in a third party application, be sure to save it with the same name at the same path.", nil), 
                                NSLocalizedString(@"OK", nil), nil, nil);
                return;
            }
        }
        // Create the File Open Dialog class.
        NSOpenPanel* openFilePanel = [NSOpenPanel openPanel];
        
        // Enable the selection of files in the dialog.
        [openFilePanel setCanChooseFiles:YES];
        
        // Disable the selection of directories in the dialog.
        [openFilePanel setCanChooseDirectories:NO];
        
        // Change text of the open button in file dialog
        [openFilePanel setPrompt:NSLocalizedString(@"Choose",nil)];
        
        // Change default directory in file dialog
        [openFilePanel setDirectoryURL:[NSURL fileURLWithPath:[preferences stringForKey:@"downloadDirectory"]]];
        
        // Display the dialog.  If the OK button was pressed,
        // process the files.
        [openFilePanel beginSheetModalForWindow:self
                              completionHandler:^(NSInteger result) {
                                  if (result == NSFileHandlingPanelOKButton) {
                                      // Get an array containing the full filenames of all
                                      // files and directories selected.
                                      NSArray* files = [openFilePanel URLs];
                                      NSString* fileName = [[files objectAtIndex:0] path];
                                      [resultListener chooseFilename:fileName];
                                  }
                              }];
    }
}


- (void)webView:(WebView *)sender decidePolicyForMIMEType:(NSString*)type 
        request:(NSURLRequest *)request 
          frame:(WebFrame *)frame
decisionListener:(id < WebPolicyDecisionListener >)listener
{
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    if (![type isEqualToString:@"application/pdf"] || ![preferences boolForKey:@"downloadPDFFiles"]) {
        if ([WebView canShowMIMEType:type]) {
            [listener use];
            return;
        }
    }
    // If MIME type cannot be displayed by the WebView, then we download it
//#ifdef DEBUG
    NSLog(@"MIME type to download is %@", type);
//#endif
    [listener download];
    [self startDownloadingURL:request.URL];
}


// Handle WebView load errors
- (void)webView:(WebView *)sender didFailProvisionalLoadWithError:(NSError *)error
       forFrame:(WebFrame *)frame {
    
	if ([error code] != -999) {
        
        if ([error code] !=  WebKitErrorFrameLoadInterruptedByPolicyChange) //this error can be ignored
        {
            NSString *titleString = NSLocalizedString(@"Error Loading Page",nil);
            NSString *messageString = [error localizedDescription];
            //NSPanel *alertPanel = NSGetAlertPanel(titleString, messageString, NSLocalizedString(@"Retry",nil), NSLocalizedString(@"Cancel",nil), nil, nil);
            //[alertPanel setLevel:NSScreenSaverWindowLevel];

            int answer = NSRunAlertPanel(titleString, messageString, NSLocalizedString(@"Retry",nil), NSLocalizedString(@"Cancel",nil), nil, nil); //[NSApp runModalForWindow:alertPanel];
            switch(answer) {
                case NSAlertDefaultReturn:
                    //Retry: try reloading
                    //[[MyGlobals sharedMyGlobals] setCurrentMainHost:nil];
                    [[sender mainFrame] loadRequest:
                     [NSURLRequest requestWithURL:[NSURL URLWithString:[[MyGlobals sharedMyGlobals] currentMainHost]]]];
                    return;
                default:
                    return;
            }
        }
	}
}


- (void)startDownloadingURL:(NSURL *)url
{
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    if ([preferences boolForKey:@"allowDownUploads"] == YES) {
        // If downloading is allowed
        // Create the request.
        NSURLRequest *theRequest = [NSURLRequest requestWithURL:url
                                                cachePolicy:NSURLRequestUseProtocolCachePolicy
                                            timeoutInterval:60.0];
        // Create the download with the request and start loading the data.
        NSURLDownload  *theDownload = [[NSURLDownload alloc] initWithRequest:theRequest delegate:self];
        if (!theDownload) {
            NSLog(@"Starting the download failed!"); //Inform the user that the download failed.
        }
    }
}


- (void)download:(NSURLDownload *)download decideDestinationWithSuggestedFilename:(NSString *)filename
{
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    downloadPath = [preferences stringForKey:@"downloadDirectory"];
    if (!downloadPath) {
        //if there's no path saved in preferences, set standard path
        downloadPath = [NSHomeDirectory() stringByAppendingPathComponent:@"Downloads"];
        [preferences setObject:downloadPath forKey:@"downloadDirectory"];
    }
    NSString *destinationFilename = [downloadPath stringByAppendingPathComponent:filename];
    [download setDestination:destinationFilename allowOverwrite:NO];
}


- (void)download:(NSURLDownload *)download didFailWithError:(NSError *)error
{
    // Release the download.
    [download release];
    
    // Inform the user
    //[self presentError:error modalForWindow:[self windowForSheet] delegate:nil didPresentSelector:NULL contextInfo:NULL];

    NSLog(@"Download failed! Error - %@ %@",
          [error localizedDescription],
          [[error userInfo] objectForKey:NSURLErrorFailingURLStringErrorKey]);
}


- (void)downloadDidFinish:(NSURLDownload *)download
{
    // Release the download.
    [download release];
    
    NSLog(@"Download of File %@ did finish.",downloadPath);
    NSUserDefaults *preferences = [NSUserDefaults standardUserDefaults];
    if ([preferences boolForKey:@"openDownloads"] == YES) {
    // Open downloaded file
    [[NSWorkspace sharedWorkspace] openFile:downloadPath];
    }
}


-(void)download:(NSURLDownload *)download didCreateDestination:(NSString *)path
{
    // path now contains the destination path
    // of the download, taking into account any
    // unique naming caused by -setDestination:allowOverwrite:
    NSLog(@"Final file destination: %@",path);
    downloadPath = path;
    NSMutableArray *downloadPaths = [NSMutableArray arrayWithArray:[[MyGlobals sharedMyGlobals] downloadPath]];
    if (!downloadPaths) {
        downloadPaths = [NSMutableArray arrayWithCapacity:1];
    }
    [downloadPaths addObject:downloadPath];
    [[MyGlobals sharedMyGlobals] setDownloadPath:downloadPaths];
    [[MyGlobals sharedMyGlobals] setLastDownloadPath:[downloadPaths count]-1];
}


@end
