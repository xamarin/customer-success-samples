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
			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_WebViewRenderer").Css("SPAN.menu"));
			app.Screenshot("Tapped on view with class: Xamarin_Forms_Platform_iOS_WebViewRenderer");
			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_WebViewRenderer").XPath("//DIV[@class=\"navigation in\"]/UL/LI[@class=\"show-on-mobile\"][1]/A"));
			app.Screenshot("Tapped on view with class: Xamarin_Forms_Platform_iOS_WebViewRenderer");
			app.ScrollDownTo(x => x.Class("Xamarin_Forms_Platform_iOS_WebViewRenderer").XPath("//A[@class=\"microsoft-logo\"]/IMG"));
			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_WebViewRenderer").XPath("//A[@class=\"microsoft-logo\"]/IMG"));
			app.Screenshot("Tapped on view with class: Xamarin_Forms_Platform_iOS_WebViewRenderer");
		}
	}
}

