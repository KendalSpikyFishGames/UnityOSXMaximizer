//
//  Plugin.m
//  UnityMaximize
//
//  Created by KENDAL N. CORMANY on 11/3/16.
//  Copyright © 2016 Spiky Fish Games, LLC. All rights reserved.
//

#import <Foundation/Foundation.h>

#import <Cocoa/Cocoa.h>

#import "Plugin.h"


void InitPlugin(float inWidth, float InHeight)
{
    NSWindow *currentWindow = [NSApp keyWindow]; //Get window
    
    [currentWindow setFrame:NSMakeRect(0.f, -InHeight, inWidth, InHeight) display:YES animate:YES]; //Set window, top left is negative height.
}



