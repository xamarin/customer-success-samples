using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using MobileLifeCycleSampleApp;

namespace UITest
{
    [TestFixture(Platform.Android)]
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
            app.Screenshot("App Started");
        }

        [Test]
        public void SmokeTest()
        {
        }

		[Ignore]
        [Test]
        public void TapCrashButton()
        {
            app.Tap(x => x.Marked(AutomationIdConstants.CrashButtonAutomationId));
        }

		[Test]
		public void GiveFeedback()
		{
			app.Tap(x => x.Marked(AutomationIdConstants.FeedbackButtonAutomationId));
			app.Screenshot("Feedback Button Tapped");
		}
    }
}

