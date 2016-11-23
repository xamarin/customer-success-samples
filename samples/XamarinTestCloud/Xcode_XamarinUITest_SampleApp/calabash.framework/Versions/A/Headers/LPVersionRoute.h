//
//  LPVersionRoute.h
//  calabash
//
//  Created by Karl Krukow on 22/06/12.
//  Copyright (c) 2012 LessPainful. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "LPRoute.h"

/*** UNEXPECTED ***
 We have tools that search the strings in the compiled binary for a match on
 'CALABASH VERSION'.

 eg. $ strings Briar-cal.app/Briar-cal | grep -E 'CALABASH VERSION'

 We use this information to determine the version of the server that is compiled
 into binary.

 Do not change the 'CALABASH VERSION' portion of the following constant without
 updating the ruby API.
 ******************/
#define kLPCALABASHVERSION @"CALABASH VERSION: 0.20.3"

@interface LPVersionRoute : NSObject <LPRoute>

@end
