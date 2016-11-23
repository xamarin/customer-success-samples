#import <Foundation/Foundation.h>
#import "LPHTTPResponse.h"


@interface LPHTTPDataResponse : NSObject <LPHTTPResponse> {
  NSUInteger offset;
  NSData *data;
}

- (id)initWithData:(NSData *)data;

@end
