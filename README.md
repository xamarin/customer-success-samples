Customer Success
=======

##### This is where the Customer Success Team houses code samples, projects, and other examples.

Because the sample galleries are powered by the github sample repos, each sample needs to have the following things:

* **Screenshots** - a folder called Screenshots that has at least one screen shot of the sample (preferably a screen shot for every page or every major functionality piece, people really key off these things). for the xplat samples, the folder should be split into platform folders, e.g. iOS, Android, Windows. see[ https://github.com/xamarin/mobile-samples/tree/master/Tasky/Screenshots](https://github.com/xamarin/mobile-samples/tree/master/Tasky/Screenshots) for an example of this.

* **Readme** - a[ README.md](http://readme.md/) file that has the name of the sample, a description, and author attribution. sample here:[ https://github.com/xamarin/mobile-samples/blob/master/Tasky/README.md](https://github.com/xamarin/mobile-samples/blob/master/Tasky/README.md)

* **Metadata** - Finally, it needs a Metadata.xml file ([https://github.com/xamarin/mobile-samples/blob/master/Tasky/Metadata.xml](https://github.com/xamarin/mobile-samples/blob/master/Tasky/Metadata.xml)) that has some information:

    * **ID** - A GUID for the sample. You can generate this in MD under Tools menu : Insert GUID. we need this to key between articles and their associated samples

    * **IsFullApplication** - Boolean flag (true or false): whether or not this is a full application such as the MWC App, Tasky, etc., or it's just a feature sample, such as, how to use 'x' feature. the basic test here is, if you would submit this to the app store because it's useful, then it's a full app, otherwise it's just a feature sample.

    * **Brief** - Short description or what your sample does. This allows us to display a nice and clean vignette on the sample page.

    * **Level** - Beginning, Intermediate, or Advanced: this is the intended audience level for the sample. only the getting started samples are Beginning, as they are intended for people who are _just_ starting with the platform. most samples are Intermediate, and a few, that dive deep into difficult APIs, should be Advanced.

    * **Minimum License Requirement** - Starter, Indie, Business, or Enterprise: denotes the license that a user has to have in order to build/run the sample.

    * **Tags**: a list of relevant tags for the app. These are:
		* **Data**
		* **User Interface**
		* **Games**
		* **Graphics** (CoreDrawing, Animation, OpenGL...)
		* **Media** (Video, Sound, recording, photos)
		* **Platform Features** (Photo Library, Contacts, Calendars, etc.)
		* **Device Features** (NFC, Accelerometer, Compass, Magnemometer, Bluetooth, RFID)
		* **Cloud** (Web Services, Networking, etc.)
		* **Backgrounding**
		* **Maps + Location**
		* **Binding + Interop** (Projections)
		* **Notifications**
		* **Touch**
		* **Getting Started**
		* **Async**
		* **Extension**
		* **iOS8**
		* **iOS9**
		* **Watch**
		* **Keyboard**
		* **SceneKit**
		* **FSharp**

    * **SupportedPlatforms**: this is only for cross plat samples. It's a comma-separated list, and the valid values are iOS, Android, and Windows.

    * **Gallery**: This tag must contain a value of true if you want the sample to show up in the samples gallery on the developer portal.

* **Buildable Sln and CSProj file** - the project _must_ build and have the appropriate project scaffolding (solution + proj).

A good example of this stuff is here in the drawing sample:[ https://github.com/xamarin/monotouch-samples/tree/master/Drawing](https://github.com/xamarin/monotouch-samples/tree/master/Drawing)

For a x-platform sample, please see: https://github.com/xamarin/mobile-samples/tree/master/Tasky
###### Please be sure to add a .gitignore file to your "packages" folder with the text below before committing any code! Also, add the .gitignore in the repo to your project to get rid of your bin/obj folders and some other stuff. This cuts down significantly on the size of the repo!

```
*
!.gitignore
!repositories.config
```
