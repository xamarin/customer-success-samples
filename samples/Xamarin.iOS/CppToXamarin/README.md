#C++ To Objective-C Bound in Xamarin.iOS

##About

The purpose of this sample is to demonstrate the technique of wrapping a C++ class in Objective-C and binding it to Xamarin.iOS.

###Requirements
1. Xamarin Studio
2. Xcode
3. [Objective Sharpie](https://files.xamarin.com/~abock/ObjectiveSharpie/latest)


###How To Use This Sample

Once you've cloned this repository:


1. Type ```make``` to compile the static archive
2. Type ```sharpie update``` to check for Objective Sharpie updates
3. Type ```sharpie xcode -sdks``` to determine what version of iOS you have installed
4. Type ```sharpie bind -output Wrapping -sdk iphoneos8.4 C++WrappedInObjC/C++WrappedInObjective-C/C++WrappedInObjective-C/StringWrapped.h -c -Ibuild/Headerss```
     * Make sure your sdk versions match up.

Sharpie is targeting iOS SDK 8.4 because ```sharpie xcode -sdks``` returns:

    jond-mac-1540: jond$ sharpie xcode -sdks
    sdk: iphoneos8.4    arch: arm64   armv7
    sdk: macosx10.10    arch: x86_64  i386
    sdk: macosx10.9     arch: x86_64  i386

###Screenshot

![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/CppToXamarin/Screenshot/1.png "Xamarin.iOS Screenshot")

###Xamarin.iOS Version
This sample was written with [Xamarin.iOS 8.0](http://xamarin.com/platform)

###Author
Jon Davis