Advanced PCL / Bait and Switch
=====
This sample demonstrates the Advanced PCL / Bait and Switch technique through the creation of a mock database in an iOS Library. This sample also comes with a basic implementation of Mono.Data.Sqlcipher through the interfaces of the sample.

## About
The Bait and Switch PCL Trick is fully documented by Paul Betts. I urge anyone new to this to read his [blog post](http://log.paulbetts.org/the-bait-and-switch-pcl-trick/) before continuing.

A key point of this sample is to demonstrate the ability of the PCL client to speak to platform specific implementations such as [Sqlcipher for Xamarin.iOS](https://components.xamarin.com/view/sqlcipher-for-xamarin-ios).

The iOS project includes a light, commented out, version of a Sqlcipher implementation. The reason for it being commented out is that anyone without the Sqlcipher component can benefit from this sample. The client speaks to the interfaces in the AdvancedUser.Infrastructure class. The implementation of the project works off mock objects in the AdvancedUser.DataAccessLayer.Mocks namespace.

#Screenshot
![screenshot](https://github.com/xamarin/customer-success/blob/AdvancedPCL/samples/Xamarin.iOS/AdvancedPCL/Screenshot/1.png "Xamarin.iOS, Bait and Switch")

Xamarin.iOS Version
---------------------
This sample was written with [Xamarin.iOS 8.0](http://xamarin.com/platform)

Authors
-------
Jon Davis
