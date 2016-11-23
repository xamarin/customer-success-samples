#import <UIKit/UIKit.h>

@protocol LPWebViewProtocol <NSObject>

@required

// The bridge between UIWebView and WKWebKit.
- (NSString *) calabashStringByEvaluatingJavaScript:(NSString *) javascript;

- (BOOL) pointInside:(CGPoint) point withEvent:(UIEvent *) event;
- (UIScrollView *) scrollView;

@end
