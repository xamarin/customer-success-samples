using System.Threading.Tasks;

using HockeyApp.Android;

using Xamarin.Forms;

using MobileLifeCycleSampleApp.Services;
using MobileLifeCycleSampleApp.Droid.Services;

[assembly: Dependency(typeof(FeedbackManager_Android))]
namespace MobileLifeCycleSampleApp.Droid.Services
{
    class FeedbackManager_Android : IFeedbackManager
    {
        public async Task<bool> DisplayFeedbackPage()
        {
            await Task.Run(() => FeedbackManager.ShowFeedbackActivity(Forms.Context));

            return true;
        }
    }
}