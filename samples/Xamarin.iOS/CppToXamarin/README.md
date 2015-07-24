C++ Wrapped in Objective-C Bound in Xamarin.iOS
=====
##About
The purpose of this sample is to demonstrate the techqniue of binding C++ classes in Objective-C to Xamarin.iOS.
###Requirements
1) Xamarin Studio
2) Xcode
3) [Objective Sharpie](https://files.xamarin.com/~abock/ObjectiveSharpie/latest)

####How To Use This Sample
Once you've cloned this repository:
1) Type ```make``` 
2) Type ```sharpie update```
3) Type ```sharpie xcode -sdks```
4) Type ```sharpie bind -output Wrapping -sdk iphoneos8.4 C++WrappedInObjC/C++WrappedInObjective-C/C++WrappedInObjective-C/StringWrapped.h -c -Ibuild/Headerss```
     * Make sure your sdk versions match up.

An example output for ```sharpie xcode -sdks``` returns:

    jond-mac-1540: jond$ sharpie xcode -sdks
    sdk: iphoneos8.4    arch: arm64   armv7
    sdk: macosx10.10    arch: x86_64  i386
    sdk: macosx10.9     arch: x86_64  i386

For this reason, target iphoneos8.4

run: sharpie bind -output Wrapping -sdk iphoneos8.4 C++WrappedInObjC/C++WrappedInObjective-C/C++WrappedInObjective-C/StringWrapped.h -c -Ibuild/Headers

#Screenshot
![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/CppToXamarin/Screenshot/1.png "Xamarin.iOS Screenshot")
Xamarin.iOS Version
---------------------
This sample was written with [Xamarin.iOS 8.0](http://xamarin.com/platform)
Author
-------
Jon Davis