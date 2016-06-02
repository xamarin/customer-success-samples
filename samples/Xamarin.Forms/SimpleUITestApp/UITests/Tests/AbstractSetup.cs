using NUnit.Framework;
using Xamarin.UITest;

namespace SimpleUITestApp.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]

	public abstract class AbstractSetup
	{
		protected IApp app;
		protected Platform platform;

		protected FirstPage FirstPage;
		protected ListViewPage ListViewPage;

		protected AbstractSetup (Platform platform)
		{
			this.platform = platform;
		}
		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
			app.Screenshot("App Initialized");

			FirstPage = new FirstPage(app, platform);
			ListViewPage = new ListViewPage(app, platform);
		}
	}
}

