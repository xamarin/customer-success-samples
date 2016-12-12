//
//  LPRoute.h
//
//  Created by Karl Krukow on 13/08/11.
//  Copyright 2011 LessPainful. All rights reserved.
//

#import <Foundation/Foundation.h>

@class LPHTTPConnection;

@protocol LPRoute <NSObject>

@optional
- (void) setParameters:(NSDictionary *) parameters;

- (void) setConnection:(LPHTTPConnection *) connection;

- (BOOL) supportsMethod:(NSString *) method atPath:(NSString *) path;

- (NSDictionary *) JSONResponseForMethod:(NSString *) method
                                     URI:(NSString *) path
                                    data:(NSDictionary *) data;

@end
