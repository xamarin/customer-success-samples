#import <UIKit/UIKit.h>

@interface LPWebViewUtils : NSObject

+ (BOOL) isWebView:(id) object;
+ (BOOL) isIFrameResult:(NSDictionary *)result;

@end
