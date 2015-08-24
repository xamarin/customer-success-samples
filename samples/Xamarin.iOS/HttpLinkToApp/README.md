Http Link to iOS Mobile App
=====
The purpose of this sample is to create an app specific URLScheme that triggers your app to load with a payload from Safari.

## How to use

1. Run the HttpLinkToApp in the simulator or on a device
2. Click this [link](xamapp://?data=123)
3. Or, in Safari, enter: xamapp://?data=123

## How it works
1. In Info.plist register a URLScheme (xamapp)
```
<key>CFBundleURLTypes</key>
	<array>
		<dict>
			<key>CFBundleURLName</key>
			<string>com.xamarin.httplinktoapp</string>
			<key>CFBundleURLSchemes</key>
			<array>
				<string>xamapp</string>
			</array>
		</dict>
	</array>
```
2. In AppDelegate, implement ```bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)``` to handle the payload
 

## Screenshot
![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/HttpLinkToApp/Screenshot/1.png "Screenshot")

Xamarin.iOS Version
---------------------
This sample was written with [Xamarin.iOS 8.0](http://xamarin.com/platform)

Author
-------
Jon Davis: [GitHub](https://github.com/jon-davis-xamarin)
