using Xamarin.UITest;
using Xamarin.UITest.iOS;
using FormsKitchenSink.Util;

namespace FormsKitchenSink.UITests.Pages
{
    public class MainListPage : PageBase
    {
        #region method overrides
        public override PageBase VerifyPresent()
        {
            app.WaitForElement(IDs.MainListScreen.ScreenId);
            return this;
        }
        #endregion

        #region methods
        public MainListPage TapListItemWithId(string listItemId) 
        {
            app.WaitForElement(listItemId);
            app.Tap(listItemId);
            return this;
        }

        public void NavigateToOrangeScreenUsingBackdoor()
        {
            if (app is iOSApp)
                app.Invoke("navigateToOrangeScreen:", "");
            else
                app.Invoke("NavigateToOrangeScreen");
        }
        #endregion

        #region constructors
        public MainListPage(IApp app, Platform platform) : base(app, platform) { }
        #endregion

    }
}

