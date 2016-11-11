using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Linq;
using Xamarin.UITest.iOS;

namespace FormsKitchenSink.UITests.Pages
{
    public class PageBase
    {
        #region properties & fields
        protected readonly IApp app;
        protected readonly Platform platform;
        #endregion

        #region methods
        public virtual void VerifyPresent() { }
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

