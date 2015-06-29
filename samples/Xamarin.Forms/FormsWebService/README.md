##Forms Webrequests - The Amazing Power ModernHttpClient

This sample displays making both synchronous and asynchronous webrequests that utilize the [ModernHttpClient](https://github.com/paulcbetts/ModernHttpClient) NuGet Package. After launching the project, there are two buttons, one to start an asynchronous webrequest and another to start a synchronous webrequest. Clicking between the two buttons will display how the two will behave.

* You'll notice the "Async Webrequest" will load the text into the editor and change the background color at the same time. (Really the text is loaded slighty ahead of the background color because of the await)
* The "Synchronous Webrequest" will load the text into the editor after the background color is updated. This is because the change in text is not done using async/await, but rather loaded once the data is returned.

In all reality, the webrequest is done asynchronously in both calls. The main difference is that we kick off the request and wait for the results before proceeding, or we kick off the request and continue. In this example we can just kick off the request because we passed in the editor to our request which enables us to modify the text. Another way to acheive this would be to utilize the [MessagingCenter](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/messaging-center/).


##Author
Michael Watson  
Customer Success Engineer  
Xamarin.Forms and Xamarin.Android Specialist
