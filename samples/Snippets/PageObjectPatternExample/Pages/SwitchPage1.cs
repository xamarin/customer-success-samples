using Xamarin.UITest;
using System.Linq;
using FormsKitchenSink.Util;
using Xamarin.UITest.Android;

namespace FormsKitchenSink.UITests.Pages
{
    public class SwitchPage1 : PageBase
    {
        #region constants
        public const string Black = "#000000";
        public const string White = "#FFFFFF";
        public const string OtherColor = "OtherColor";
        private const string iOSBlack = "UIExtendedSRGBColorSpace 0 0 0 1";
        private const string iOSWhite = "UIExtendedSRGBColorSpace 1 1 1 1";
        private const int AndroidBlack = -16777216;
        private const int AndroidWhite = -1;
        #endregion

        #region property overrides
        public string BackgroundColor
        {
            get
            {
                if (app is AndroidApp)
                {
                    int color = app.Query(
                        c => c.Marked(IDs.SwitchScreen1.ScreenId)
                        .Invoke("getBackground")
                        .Invoke("getColor")
                        .Value<int>()
                    ).First();
                    return
                        color == AndroidBlack ? Black :
                        color == AndroidWhite ? White : OtherColor;
                }
                else
                {
                    string colorDescription = app.Query(
                        c => c.Marked(IDs.SwitchScreen1.ScreenId)
                        .Invoke("backgroundColor")
                        .Invoke("description")
                        .Value<string>()
                    ).First();
                    return 
                        colorDescription == iOSBlack ? Black : 
                        colorDescription == iOSWhite ? White : OtherColor;
                }
            }
        }
        #endregion

        #region properties & fields
        public bool SwitchValue 
        {
            get
            {
                int value = app.Query(
                    x => x.Switch(IDs.SwitchScreen1.SwitchId)
                    .Invoke(app is AndroidApp ? "isChecked" : "isOn")
                    .Value<int>()
                ).First();
                return value > 0;
            }
        }
        #endregion

        #region method overrides
        public override PageBase VerifyPresent()
        {
            app.WaitForElement(IDs.SwitchScreen1.ScreenId);
            return this;
        }
        #endregion

        #region public methods
        public SwitchPage1 ToggleSwitch()
        {
            app.Tap(x => x.Switch(IDs.SwitchScreen1.SwitchId));
            return this;
        }
        #endregion

        #region constructors
        public SwitchPage1(IApp app, Platform platform) : base(app, platform) { }
        #endregion
    }
}

