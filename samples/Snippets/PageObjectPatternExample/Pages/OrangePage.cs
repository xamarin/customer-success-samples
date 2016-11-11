using FormsKitchenSink.Util;
using Xamarin.UITest;

namespace FormsKitchenSink.UITests.Pages
{
    public class OrangePage : PageBase
    {
        #region method overrides
        public override PageBase VerifyPresent() 
        { 
            app.WaitForElement(IDs.OrangeScreen.ScreenId);
            return this;
        }
        #endregion

        #region constructors
        public OrangePage(IApp app, Platform platform) : base(app, platform) { }
        #endregion

    }
}

