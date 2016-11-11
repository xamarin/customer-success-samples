using Xamarin.UITest;

namespace FormsKitchenSink.UITests.Pages
{
    public abstract class PageBase
    {
        #region properties & fields
        protected readonly IApp app;
        protected readonly Platform platform;
        #endregion

        #region methods
        public abstract PageBase VerifyPresent();
        #endregion

        #region constructors
        protected PageBase(IApp app, Platform platform)
        {
            this.app = app;
            this.platform = platform;
        }    
        #endregion
    }
}

