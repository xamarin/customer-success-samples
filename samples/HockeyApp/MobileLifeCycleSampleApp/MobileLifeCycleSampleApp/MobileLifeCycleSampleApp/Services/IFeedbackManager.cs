
using System.Threading.Tasks;

namespace MobileLifeCycleSampleApp.Services
{
    public interface IFeedbackManager
    {
        Task<bool> DisplayFeedbackPage();
    }
}
