using FormsKitchenSink.Util;
using Xamarin.UITest;

namespace FormsKitchenSink.UITests.Pages
{
    public class GreenPage : PageBase
    {
        #region method overrides
        public override PageBase VerifyPresent()
        {
            app.WaitForElement(IDs.GreenScreen.ScreenId);
            return this;
        }
        #endregion

        #region method overrides
        public GreenPage TapGoOrangeButton()
        {
            app.WaitForElement(IDs.GreenScreen.GoOrangeButtonId);
            app.Tap(IDs.GreenScreen.GoOrangeButtonId);
            return this;
        }
        #endregion

        #region constructors
        public GreenPage(IApp app, Platform platform) : base(app, platform) { }
        #endregion

    }
}

