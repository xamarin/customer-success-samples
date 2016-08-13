using NUnit.Framework;

using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace SimpleUITestApp.UITests
{
	[Category ("TestsAfterLoginScreen")]
	public class TestsAfterLoginScreen : BaseTest
	{
		public TestsAfterLoginScreen(Platform platform) : base(platform)
		{
			this.platform = platform;
		}

		public override void BeforeEachTest()
		{
			base.BeforeEachTest();

            LoginPage.WaitForLoginScreen();

			if (app is Xamarin.UITest.iOS.iOSApp)
				app.Invoke("bypassLoginScreen:", "");
			else
				app.Invoke("BypassLoginScreen");

			app.WaitForElement("First Page");
		}

		[Test]
		public void EnterText()
		{
			//Arrange
			var textInput = "Hello World";

			//Act
			FirstPage.EnterText(textInput);
			FirstPage.ClickGo();
			FirstPage.WaitForNoActivityIndicator();

			//Assert
			Assert.AreEqual(FirstPage.GetEntryFieldText(), textInput);
		}

		[Test]
		public void EnterTextByID()
		{
			//Arrange
			var textInput = "I used IDs to Enter this Text!";

			//Act
			FirstPage.EnterTextByID(textInput);
			FirstPage.ClickGoByID();
			FirstPage.WaitForNoActivityIndicator();

			//Assert
			Assert.AreEqual(FirstPage.GetEntryFieldTextByID(), textInput);
		}

		[Test]
		public void SelectItemOnListView()
		{
			//Arrange
			var listItemNumber = 9;
			var expectedAlertString = $"You Selected Number {listItemNumber}";

			//Act
			if (app is iOSApp)
				app.Invoke("openListViewPage:", "");
			else
				app.Invoke("OpenListViewPage");

			app.Screenshot("Backdoor to List View Page");

			ListViewPage.TapListItemNumber(listItemNumber);

			//Assert
			Assert.AreEqual(expectedAlertString, ListViewPage.GetAlertText(listItemNumber));
		}

		[Test]
		public void RotateScreenAndEnterTextByID()
		{
			//Arrange
			var entryTextLandcape = "The Screen Orientation Is Landscape";
			var entryTextPortrait = "The Screen Orientation Is Portrait";

			//Act
			FirstPage.RotateScreenToLandscape();
			FirstPage.EnterText(entryTextLandcape);
			FirstPage.ClickGoByID();
			FirstPage.WaitForNoActivityIndicator();

			//Assert
			Assert.AreEqual(FirstPage.GetEntryFieldTextByID(), entryTextLandcape);

			//Act
			FirstPage.RotateScreenToPortrait();
			FirstPage.EnterText(entryTextPortrait);
			FirstPage.ClickGoByID();
			FirstPage.WaitForNoActivityIndicator();

			//Assert
			Assert.AreEqual(FirstPage.GetEntryFieldTextByID(), entryTextPortrait);
		}
	}
}

