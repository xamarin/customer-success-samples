using NUnit.Framework;

using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Entry_UITest.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        Query MyEntry;
        Query MyLabel;

        public Tests(Platform platform)
        {
            this.platform = platform;

            //Always initialize your UITest queries using "x.Marked" and referencing the UI ID
            //In Xamarin.Forms, you set the UI ID by setting the control's "AutomationId"
            //In Xamarin.Android, you set the UI ID by setting the control's "ContentDescription"
            //In Xamarin.iOS, you set the UI ID by setting the control's "AccessibilityIdentifiers"
            MyEntry = x => x.Marked("MyEntry");
            MyLabel = x => x.Marked("MyLabel");
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
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
            app.ClearText();
            app.Screenshot("Entry Tapped");

            app.EnterText(typedText);
            app.Screenshot($"Entered Text: {typedText}");

            //Assert
            retrievedText = app.Query(MyLabel)[0].Text;
            Assert.AreEqual(typedText, retrievedText, "The typed text does not match the text displayed on the screen");
        }

		[Ignore ("Repl for testing/development only")]
        [Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}

