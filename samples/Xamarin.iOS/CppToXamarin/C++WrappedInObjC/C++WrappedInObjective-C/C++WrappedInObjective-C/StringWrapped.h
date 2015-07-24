//
//  StringWrapped.h
//  Objective-CProject
//
//  Created by Jon Davis on 7/23/15.
//  Copyright (c) 2015 Xamarin Inc. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface StringWrapped : NSObject

@property (nonatomic, copy) NSString* result;

- (id)initWithString:(NSString *)cString;

@end
