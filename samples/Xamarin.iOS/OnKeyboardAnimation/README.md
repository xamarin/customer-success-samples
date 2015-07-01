Register/Deregister for Keyboard Notification Observer & Tap Gesture Recgonizers
=====
##About
The purpose of this sample is to show the developer how to listen to keyboard notifications, tap gesturer recognizers, and how to properly dispose of them.
###Main.storyboard
Main.storyboard uses Autolayout to place the controls on the screen in the wAny hAny size class.
####BaseViewController.cs
BaseViewController, as the name of the class suggest, is the base view controller of our sample controller. BaseViewController inherits from UIViewController. Its responsibilities include listening to keyboard notifications and tap gesturers in the ViewDidLoad method as well as deregistering these observables and events in the ViewWillDisapper method. 
####ViewController.cs
ViewController.cs inherits from BaseViewController. It's marked as the Initial View Controller in Main.storyboard by the iOS Designer.
#Screenshot
![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/OnKeyboardAnimation/Screenshot/1.png "Xamarin.iOS, Keyboard Animation")
Xamarin.iOS Version
---------------------
This sample was written with [Xamarin.iOS 8.0](http://xamarin.com/platform)
Author
-------
Jon Davis