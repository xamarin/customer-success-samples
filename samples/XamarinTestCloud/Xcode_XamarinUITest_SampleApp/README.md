[![Build Status](https://www.bitrise.io/app/dbffbfe41a965ead.svg?token=rLJyd4d1zpn-AKSF6v7kkg)](https://www.bitrise.io/app/dbffbfe41a965ead)
# Xcode_XamarinUITest_SampleApp
This sample app demonstrates how to create Xamarin.UITest for an iOS app built in Xcode.

This repo contains an [iOS app made using Xcode](https://github.com/brminnick/Xcode_XamarinUITest_SampleApp/tree/master/Xcode_XamarinUITest_SampleApp.xcodeproj), and a [Xamarin.UITest made using Xamarin Studio](https://github.com/brminnick/Xcode_XamarinUITest_SampleApp/tree/master/Xcode_XamarinUITest_SampleApp.UITests).

To run a UITest against an iOS app, you will need to embed the Calabash Library by following [this tutorial](https://github.com/brminnick/Xcode_XamarinUITest_SampleApp/new/master?readme=1).

## Setup

To begin using this app, you will need to install its CocoaPods by following these steps:

* Ensure that CocoaPods is installed on your build machine
  * Open Terminal
  * Install CocoaPods
    * In the terminal, enter `sudo gem install cocoapods`
  * Ensure you have installed CocoaPods v1.0 or greater
    * In the terminal, enter `pod env`
  
* Install the CocoaPods for this project
  * In the Terminal, navigate to the project directory 
    * e.g. cd ~/Projects/Xcode_XamarinUITest_SampleApp
  * Then, install the CocoaPods for this project 
    * In the terminal, enter `pod install`

For additional information on CocoaPods, visit https://cocoapods.org.
