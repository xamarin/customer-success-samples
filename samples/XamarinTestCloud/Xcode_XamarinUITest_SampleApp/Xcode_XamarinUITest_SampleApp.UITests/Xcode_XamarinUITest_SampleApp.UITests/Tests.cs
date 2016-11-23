using System.Linq;

using NUnit.Framework;

using Xamarin.UITest;
using Xamarin.UITest.iOS;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xcode_XamarinUITest_SampleApp.UITests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		Query MyEntry;
		Query MyLabel;

		public Tests()
		{
			//Always initialize your UITest queries using "x.Marked" and referencing the UI ID
			//In Xamarin.Forms, you set the UI ID by setting the control's "AutomationId"
			//In Xamarin.Android, you set the UI ID by setting the control's "ContentDescription"
			//In Xamarin.iOS, you set the UI ID by setting the control's "AccessibilityIdentifiers"

			MyEntry = x => x.Marked(AccessibilityIdentifierConstants.TextFieldAccessibilityIdentifier);
			MyLabel = x => x.Marked(AccessibilityIdentifierConstants.LabelAccessibilityIdentifier);
		}

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the iOS app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			//
			// The iOS project should have the Xamarin.TestCloud.Agent NuGet package
			// installed. To start the Test Cloud Agent the following code should be
			// added to the FinishedLaunching method of the AppDelegate:
			//
			//    #if ENABLE_TEST_CLOUD
			//    Xamarin.Calabash.Start();
			//    #endif
			app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				.AppBundle ("../../../Xcode_XamarinUITest_SampleApp.app")
				.StartApp();

			app.WaitForElement(MyEntry);
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}

		[Test]
		public void EnterText()
		{
			//Arrange
			string typedText = "Hello world!";
			string retrievedText;

			//Act
			app.Tap(MyEntry);
			app.ClearText();
			app.Screenshot("Entry Tapped");

			app.EnterText(typedText);
			app.DismissKeyboard();
			app.Screenshot($"Entered Text: {typedText}");

			//Assert
			retrievedText = app.Query(MyLabel).FirstOrDefault()?.Text;
			Assert.AreEqual(typedText, retrievedText, "The typed text does not match the text displayed on the screen");
		}

		[Ignore("Repl for testing/development only")]
		[Test]
		public void Repl()
		{
			app.Repl();
		}
	}
}
