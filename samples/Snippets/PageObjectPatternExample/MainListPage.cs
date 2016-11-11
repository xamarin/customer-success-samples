using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Linq;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Android;
using System.Reflection;
using FormsKitchenSink.Util;

namespace FormsKitchenSink.UITests.Pages
{
    public class MainListPage : PageBase
    {
        #region method overrides
        public override void VerifyPresent()
        {
            app.WaitForElement(IDs.MainListScreen.ScreenId);
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
            {
                ((iOSApp)app).Invoke("navigateToOrangeScreen:", "");
            }
            else
            {
                ((AndroidApp)app).Invoke("NavigateToOrangeScreen");
            }
        }
        #endregion

        #region constructors
        public MainListPage(IApp app, Platform platform) : base(app, platform) { }
        #endregion

    }
}

