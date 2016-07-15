using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using UIKit;
using Foundation;
using LocalAuthentication;

using Xamarin.Forms;

using SimpleUITestApp.iOS;

[assembly: Dependency(typeof(Login_iOS))]
namespace SimpleUITestApp.iOS
{
	public class Login_iOS : ILogin
	{
		public void AuthenticateWithTouchId(LoginPage page)
		{
			if (!UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
				return;

			var hasLoginKey = NSUserDefaults.StandardUserDefaults.BoolForKey("hasLogin");
			if (string.IsNullOrEmpty(App.UserName))
				return;

			var username = NSUserDefaults.StandardUserDefaults.ValueForKey(new NSString("username")).ToString();

			if (string.IsNullOrEmpty(username))
				return;

			var context = new LAContext();
			NSError AuthError;
			var myReason = new NSString("Login to expense portal");

			if (context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out AuthError))
			{
				var replyHandler = new LAContextReplyHandler((success, error) =>
				{

					if (error != null)
						if (error.LocalizedDescription == "Canceled by user.")
							return;

					if (success)
					{
						Console.WriteLine("Success!!");
						var userName = NSUserDefaults.StandardUserDefaults.ValueForKey(new NSString("username")).ToString();

						Xamarin.Insights.Identify(userName, new Dictionary<string, string> {
							{ "User Type", "NonApprover" },
						});
					}

					page.TouchIdSuccess = success;
				});
				context.EvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, myReason, replyHandler);
			};
		}

		public async Task<bool> SetPasswordForUsername(string username, string password)
		{
			if (string.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
				return false;

			KeychainHelpers.SetPasswordForUsername(username, password, "XamarinExpenses", Security.SecAccessible.Always, true);
			NSUserDefaults.StandardUserDefaults.SetString(username, "username");
			NSUserDefaults.StandardUserDefaults.SetBool(true, "hasLogin");
			NSUserDefaults.StandardUserDefaults.Synchronize();

			return true;
		}

		public async Task SaveUsername(string username)
		{
			NSUserDefaults.StandardUserDefaults.SetString(username, "username");
		}

		public async Task<bool> CheckLogin(string username, string password)
		{
			var _username = NSUserDefaults.StandardUserDefaults.ValueForKey(new NSString("username"));
			var _password = KeychainHelpers.GetPasswordForUsername(username, "XamarinExpenses", true);

			if (_username == null || _password == null)
				return false;

			if (password == _password &&
				username == _username.ToString())
			{
				return true;
			}

			return false;
		}

		public async Task<string> GetSavedUsername()
		{
			var userName = NSUserDefaults.StandardUserDefaults.ValueForKey(new NSString("username"));

			if (userName != null)
				return userName.ToString();
			else
				return "";
		}
	}
}

