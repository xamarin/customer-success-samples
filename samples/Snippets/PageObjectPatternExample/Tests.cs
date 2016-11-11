using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using FormsKitchenSink.UITests.Pages;
using FormsKitchenSink.Util;

namespace FormsKitchenSink.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        #region properties & fields
        IApp app;
        Platform platform;
        MainListPage mainListPage;
        SwitchPage1 switchPage;
        GreenPage greenPage;
        OrangePage orangePage;
        #endregion

        #region constructors
        public Tests(Platform platform)
        {
            this.platform = platform;
        }
        #endregion

        #region setup & configuration
        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);

            // Initialize these pages here as a convenience, to prevent
            // the need to clutter up test code with the instantiation
            // of these objects
            mainListPage = new MainListPage(app, platform);
            switchPage = new SwitchPage1(app, platform);
            greenPage = new GreenPage(app, platform);
            orangePage = new OrangePage(app, platform);
        }
        #endregion

        #region tests
        [Test]
        [Ignore]
        public void ReplTest()
        {
            app.Repl();
        }

        [Test]
        public void NonPageObjectPatternTest()
        {
            // On the main screen, tap the switch screen cell
            app.WaitForElement(IDs.MainListScreen.ScreenId);
            app.WaitForElement(IDs.MainListScreen.SwitchScreen1CellId);
            app.Tap(IDs.MainListScreen.SwitchScreen1CellId);

            // On the switch screen, make sure the switch is off / background is black
            app.WaitForElement(IDs.SwitchScreen1.ScreenId);
            int value = app.Query(
                x => x.Switch(IDs.SwitchScreen1.SwitchId)
                .Invoke(platform == Platform.Android ? "isChecked" : "isOn")
                .Value<int>()
            ).First();
            Assert.True(value == 0, "Expected switch to be off.");
        }

        [Test]
        public void TestSwitchScreen1()
        {
            // Start on the main list
            app.Screenshot("On main list screen");
            mainListPage.VerifyPresent();

            // Tap the cell with ID "switchScreen1"
            mainListPage.TapListItemWithId(IDs.MainListScreen.SwitchScreen1CellId);
            app.Screenshot("Tapped the first Switch cell");
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

        [Test]
        public void TestOrangeScreenWithoutBackdoor()
        {
            // Start on the main list
            app.Screenshot("On main list screen");
            mainListPage.VerifyPresent();

            // Tap on the orange screen button (which first goes to the green screen)
            mainListPage.TapListItemWithId(IDs.MainListScreen.OrangeScreenCellId);
            app.Screenshot("On green screen");
            greenPage.VerifyPresent();

            // Tap on the 'Go Orange' button (which navigates to the orange screen)
            greenPage.TapGoOrangeButton();
            app.Screenshot("On orange screen");
            orangePage.VerifyPresent();

            // Tap back
            app.Back();
            app.Screenshot("Back on green screen");
            greenPage.VerifyPresent();

            // Tap back again
            app.Back();
            app.Screenshot("Back on main list screen");
            mainListPage.VerifyPresent();
        }

        [Test]  
        public void TestOrangeScreenWithBackdoor()
        {
            // Start on the main screen
            app.Screenshot("On main list screen");
            mainListPage.VerifyPresent();

            // Navigate directly to the orange screen via backdoor
            // (skipping the green screen)
            mainListPage.NavigateToOrangeScreenUsingBackdoor();
            app.Screenshot("On orange screen");
            orangePage.VerifyPresent();

            // Go back (to the green screen, which comes before the orange
            // screen in the navigation hierarchy)
            app.Back();
            app.Screenshot("On green screen");
            greenPage.VerifyPresent();

            // Go back again (to the main list)
            app.Back();
            app.Screenshot("Back on main list screen");
            mainListPage.VerifyPresent();
        }
        #endregion
    }
}

