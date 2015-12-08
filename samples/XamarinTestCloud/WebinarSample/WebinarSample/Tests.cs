using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;
using System.Reflection;
using System.Threading;

namespace WebinarSample
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;
		private int width = 0;
		private int height = 0;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void VerifyContactData ()
			{
			if (platform == Platform.iOS) {	
				app.Screenshot ("Given when I start the app");	
				app.WaitForThenTap (x => x.Id ("slideout.png"), "Then I tap the menu button on homescreen");
				app.WaitForThenTap (x => x.Marked ("Leads"), "Then I tap the Accounts button");
				app.WaitForThenTap (x => x.Text ("Bay Unified School District"), "Then I tap the first account");		

				Console.WriteLine("Here is some important information!");

			} else {
				
				app.WaitForThenTap(x => x.Id("up"), "Then I tap the menu button on homescreen");		
				app.WaitForThenTap(x => x.Text("Accounts"), "Then I tap the Accounts button");					
				app.WaitForThenTap(x => x.Text("Bay Unified School District") , "Then I tap Bay Unified School District");
				app.WaitForThenTap(x => x.Text("History"), "Then I tap the history button");
				app.WaitForThenTap(x => x.Text("Paper"), "Then I tap the first order button");
				app.WaitForThenGetTextOfIndexAndCompare(x => x.Class("FormsTextView"), 2, "Paper", "Then I verify that the Paper entry is valid");
			}								
		}

		[Test]	
		public void VerifyProductInventory()
		{
			//iOS Only!
			if (platform == Platform.iOS) {
				app.Screenshot("Given when I start the app");
				app.WaitForThenTap(x => x.Id("slideout.png"), "Then I tap the menu button on homescreen");
				app.WaitForThenTap (x => x.Id ("productcatalog.png"), "Then I tap on the product catalog");

				Assert.IsTrue (app.IsItThere (x => x.Text ("Copy & Print Paper, 8 1/2 x 11, 20 Lb.")));
				app.Screenshot ("Then I should I should see Copy Paper product");
				SwipeLeftMod ();

				Assert.IsTrue (app.IsItThere (x => x.Text ("Replacement CMYK Inkjet Ink.")));
				app.Screenshot ("Then I swipe left to Ink product");
				SwipeLeftMod ();

				Assert.IsTrue (app.IsItThere (x => x.Text ("Multifunction Laser All-In-One Color Printer.")));
				app.Screenshot ("Then I swipe left to Color Printer product");
				SwipeLeftMod ();

				Assert.IsTrue (app.IsItThere (x => x.Text ("XL9000 Industrial Scanner.")));
				app.Screenshot ("Then I swipe left to Color Printer product");
			}

		}

		//For reference
		private void SwipeLeftMod()
		{
			app.GetHeightWidth (
				x => x.Class("UIView").Index(0),
				out width,
				out height
			);				

			//This will scroll from the total width of the control all the way to 0 at half the height down 
			app.DragCoordinates (width - 5, height / 2 , 0, height / 2);
		}	
			
		private void TestGPS()
		{	
			double latitude = 37.78/* N */;
			double longitude = 122.41 /* W */;

			app.Device.SetLocation (latitude, longitude);
		}

		private void TestWebView()
		{
			//Example of web interactions
			app.WaitForThenEnterText(
				x => x.Id("NoResourceEntry-42")
				.Raw("webView css:'#cred_userid_inputtext'"), 
				"sally@xamcrm.onmicrosoft.com", 
				"Then I enter the user email");			
			app.WaitForThenTap(x => x.Id("NoResourceEntry-42").Raw("webView css:'#keep_me_signed_in_label_text'"),"Then I press the Keep Me Signed In checkbox");
			app.WaitForThenEnterText(x => x.Id("NoResourceEntry-42").Raw("webView css:'#cred_password_inputtext'"), "","Then I enter the user password");
		}

	}
}

