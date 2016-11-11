using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using FormsKitchenSink.UITests.Pages;
using FormsKitchenSink.Util;

namespace FormsKitchenSink.UITests
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

        [Test]
        [Ignore]
        public void ReplTest()
        {
            app.Repl();
        }

        [Test]
        public void TestSwitchScreen1()
        {
            app.Screenshot("On main list screen");
            var mainListPage = new MainListPage(app, platform);
            mainListPage.VerifyPresent();

            // Tap the cell with ID "switchScreen1"
            mainListPage.TapListItemWithId(IDs.MainListScreen.SwitchScreen1CellId);
            app.Screenshot("Tapped the first Switch cell");
            var switchPage = new SwitchPage1(app, platform);
            switchPage.VerifyPresent();
            Assert.IsFalse(switchPage.SwitchValue, "Expected switch to be off.");
            Assert.AreEqual(switchPage.BackgroundColor, SwitchPage1.Black, "Expected black background");

            // Toggle the switch on
            switchPage.ToggleSwitch();
            app.Screenshot("Toggled the switch on");
            Assert.IsTrue(switchPage.SwitchValue, "Expected switch to be on.");
            Assert.AreEqual(switchPage.BackgroundColor, SwitchPage1.White, "Expected white background");

            // Toggle the switch off
            switchPage.ToggleSwitch();
            app.Screenshot("Toggled the switch off");
            Assert.IsFalse(switchPage.SwitchValue, "Expected switch to be off.");
            Assert.AreEqual(switchPage.BackgroundColor, SwitchPage1.Black, "Expected black background");

            // Navigate back to the list
            app.Back();
            app.Screenshot("Back on the main list screen");
            mainListPage.VerifyPresent();
        }
    }
}

