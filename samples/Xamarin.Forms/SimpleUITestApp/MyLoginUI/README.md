##MyExpenses Reusable UI Package
We initially chose Xamarin.Forms because of the code sharing capabilities, but what if I could tell you that this can be further extended thorough a UI package? Well it can be, let's see how:

* A UI Package is the same thing as a NuGet Package, but will obviously have a dependency on Xamarin.Forms.
	* This can also be done for Xamarin.iOS and Xamarin.Andorid, the idea is the same
* A UI Package will contain at least three pieces:
	1. PCL
	2. iOS Library Project
	3. Android Library Project
	
 We must have these three pieces because they will create portions that are installed into each portion of our project. If you want to support Windows Phone, you would also need to create a library project for that target platform. The PCL will expose all of our Xamarin.Forms code where each platform specific project will contain any renderers we create. 
 
###***Why Would I want to do this Michael?***  
In this example, we are creating a LoginPage that is used in MyExpenses. If your organization has multiple internal mobile applications they are building, it is most likely that they will all have a single authentication service based on your email. I used to work at Genentech and this is how all their applications were wired up. You use your @gene.com email and it all authenticates through the main IT portal. 

####**As developers**...
we don't ever want to re-create something without some benefit being there. If the login authentication end point will not change, that should be baked into the UI package. This would remove the need for any developer in the organization to worry about creating a login page with authentication with internal servers.

####**As an IT administrator**...
you have complete control of authentication by funneling it through one point. You don't have to worry about multiple implementations that could potentially have security flaws.

####**As a C-level executive**...
you have complete control of the branding used in applications. 

So to sum everything up:  

* **For Developers** - you don't have to create a login page, UI styling to meet branding needs, and/or authenticating with our internal servers
*  **For IT administrators** - you have complete control of various projects by controlling their authentication. Updating this is as simple as updating the NuGet package and pushing the updated package to wherever you host internal NuGet packages. 
*  **For C-level executives** - you have complete control of distributing a single themed UI control set for your developers. Let your marketing and branding teams determine the look, implement it in this package and watch how it spreads across all of your mobile projects. 

What a beautiful suite of mobile applications your company now has!!!


###Details:  
ReusableLoginPage exposes button presses through [virtual methods](https://github.com/michael-watson/MyExpenses/blob/master/Forms-Expenses/MyLoginUI/ReusableLoginPage.cs#L186) that enables a developer to override these functions to provide whatever they needed. If your organization doesn't have a single authentication point (maybe there are multiple depending on region), you can still use all of this and the virtual methods enable your developers to plug in whatever they need. The virtual methods are exposed from the [button clicked event handlers](https://github.com/michael-watson/Forms-Expenses/blob/master/MyLoginUI/MyLoginUI/ReusableLoginPage.cs#L104). 

There is a LogoFileImageSource property that allows developers to change the image used in the LoginPage. This is important for teams that are branded slightly different and may have slightly modified logos. The important thing to remember is that we give our developers options to help create beautiful applications that are delightful to use. 