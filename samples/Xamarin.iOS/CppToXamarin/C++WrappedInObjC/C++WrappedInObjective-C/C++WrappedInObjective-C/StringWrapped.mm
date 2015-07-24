//
//  StringWrapped.m
//  Objective-CProject
//
//  Created by Jon Davis on 7/23/15.
//  Copyright (c) 2015 Xamarin Inc. All rights reserved.
//

#import "StringWrapped.h"
#import "StringWorker.h" // This was added in Xcode's User Header Search Paths

// Anonymous Category in .mm file for C++ code
@interface StringWrapped ()

@property (nonatomic, readonly) StringWorker* stringWorker;

@end


@implementation StringWrapped

- (id)initWithString:(NSString *)cString
{
    self = [super init];
    
    if (self != nil)
    {
        _stringWorker = new StringWorker(cString.UTF8String);
        
        [self setResult:@(_stringWorker->String())];
    }
    
    return self;
}

// Explicit getter for string property
- (NSString *)result
{
    NSString* result = nil;
    const char* cppString = _stringWorker->String();
    
    if (cppString != NULL)
    {
        result = @(cppString);
    }
    
    return result;
}

// Explicit setter for string property
- (void)setResult:(NSString *)cString
{
    _stringWorker->SetString(cString.UTF8String);
}


// C#'s ToString() equivalent
- (NSString *)description
{
    return [self result];
}


// dealloc the c++ class. There is no ARC here
// new an object? You must delete it.
// Use malloc? You must free it.
- (void)dealloc
{
    delete _stringWorker;
}

@end