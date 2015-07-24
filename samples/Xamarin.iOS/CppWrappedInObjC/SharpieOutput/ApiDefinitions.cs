using System;
using Foundation;

// @interface StringWrapped : NSObject
[BaseType (typeof(NSObject))]
interface StringWrapped
{
	// @property (copy, nonatomic) NSString * result;
	[Export ("result")]
	string Result { get; set; }

	// -(id)initWithString:(NSString *)cString;
	[Export ("initWithString:")]
	IntPtr Constructor (string cString);
}
