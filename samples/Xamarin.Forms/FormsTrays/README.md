##Forms Webrequests - The Amazing Power ModernHttpClient

![Droid](https://raw.githubusercontent.com/xamarin/customer-success/forms-tray/samples/Xamarin.Forms/FormsTrays/Tray_Droid.gif)
![iOS](https://raw.githubusercontent.com/xamarin/customer-success/forms-tray/samples/Xamarin.Forms/FormsTrays/Tray_iOS.gif)

This sample is a basic Tray that slides out from whatever side you want! It is build out for both iOS and Android and works in a simple manner. The Tray is added to the ParentView last and is placed off the screen depending on where you want to slide it out from. The TranslateTo Animation is then utilized to open and close the Tray. The Tray is a simple ContentView that can have anything set as it's view and gives a great option for displaying item details.

The Tray does all the calculations for you also! Just setup the app screensize, as descibed [here](https://github.com/xamarin/customer-success/tree/master/samples/Xamarin.Forms/AppScreenSize), and then just pass Tray how much of the screen you want it to cover and what TrayOrientation you want. That's it!

You may also notice I used a AbsoluteLayout for my parent Layout, but you could also use a RelativeLayout. I know the question will come, "*But I want to use a StackLayout!*". You can, just add it to the AbsoluteLayout first and make it the size of the screen, then add your tray.


##Author
Michael Watson  
Customer Success Engineer  
Xamarin.Forms and Xamarin.Android Specialist
