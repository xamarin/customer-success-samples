using NUnit.Framework;

using Xamarin.UITest;

namespace InvestmentDataSampleApp.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class ReplTests
	{
		IApp app;
		Platform platform;

		public ReplTests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void ReplTest()
		{
			app.Repl();
		}
	}
}

