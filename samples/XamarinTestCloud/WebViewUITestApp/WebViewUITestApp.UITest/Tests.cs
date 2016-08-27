using NUnit.Framework;
using Xamarin.UITest;

namespace WebViewUITestApp.UITest
{
	[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

		[Ignore]
		[Test]
		public void ReplTest()
		{
			//Query the Css attributes using the Repl to explore the webview in the app
			//For example, app.Query(x => x.Css("*"))
			app.Repl();
		}

        [Test]
        public void ViewXamarinWebsite()
        {
			app.Tap(x => x.Css("SPAN.menu"));
			app.Screenshot("Menu Tapped");
			app.Tap(x => x.Css("A").Index(2));
			app.Screenshot("Products Tapped");
			app.Tap(x => x.Css("A.action-button.blue.solid"));
			app.Screenshot("Learn More About Xamarin Tapped");
		}
	}
}

