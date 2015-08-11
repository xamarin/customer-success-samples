#Xamarin Forms Custom WebView Client

This sample displays how to access the native WebView events on the iOS and Android platforms. The project utilizes the WebView renderer to determine a Custom WebView Client

* iOS utilizes UIWebViewDelegate set on the Xamarin.Forms.WebView Delegate
* Android utilizes WebViewClient and set's this on the Control

The Navigated event handler on the Xamarin.Forms.WebView will not work because we are using our own WebViewClient. In the sample I created a static event handler in the App class that allows me to bubble up events. I have gone through and implemented what Xamarin.Forms.WebViews would typically raise under the Navigated Event. This also creates the ability to raise any event from our WebViewClient to the event handler in our PCL. 

The Navigating event handler on the Xamarin.Forms.WebView will not work as well due to using out own WebViewClient. This can be implemented in the same way I have implemented the Navigated event handler. 

Why would you want to do this? Maybe a website is using JavaScript to transform the page instead of navigating to a new page. If you launch this sample, navigate around in the YouTube page by clicking on other videos. The Conole will print out the events with a classifier saying where it comes from.


##Author
Michael Watson  
Customer Success Engineer  
Xamarin.Forms and Xamarin.Android Specialist