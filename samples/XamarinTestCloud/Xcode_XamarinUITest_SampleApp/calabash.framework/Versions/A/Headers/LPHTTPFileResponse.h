#import <Foundation/Foundation.h>
#import "LPHTTPResponse.h"

@class LPHTTPConnection;


@interface LPHTTPFileResponse : NSObject <LPHTTPResponse> {
  LPHTTPConnection *connection;

  NSString *filePath;
  UInt64 fileLength;
  UInt64 fileOffset;

  BOOL aborted;

  int fileFD;
  void *buffer;
  NSUInteger bufferSize;
}

- (id)initWithFilePath:(NSString *)filePath forConnection:(LPHTTPConnection *)connection;

- (NSString *)filePath;

@end
