using System.Collections.Generic;

using Xamarin.Forms;

using MyLoginUI.Pages;

namespace SimpleUITestApp
{
	public class LoginPage : ReusableLoginPage
	{
		public LoginPage()
		{
			AutomationId = "loginPage";
		}

		public bool TouchIdSuccess
		{
			set
			{
				if (value)
				{
					Device.BeginInvokeOnMainThread(() =>
					{
						Navigation.PopAsync();
					});
				}
				else {
					DependencyService.Get<ILogin>().AuthenticateWithTouchId(this);
				}
			}
		}

		public override async void Login(string userName, string passWord, bool saveUserName)
		{
			base.Login(userName, passWord, saveUserName);

			var success = await DependencyService.Get<ILogin>().CheckLogin(userName, passWord);
			if (success)
			{
				var insightsDict = new Dictionary<string, string> {
					{ "User Type", "NonApprover" },
					{ "Uses TouchId", "Yes" },
				};

				if (saveUserName)
				{
					await DependencyService.Get<ILogin>().SaveUsername(userName);
					insightsDict.Add("Saves username", "Yes");
				}
				else {
					insightsDict.Add("Saves username", "No");
				}
				Xamarin.Insights.Identify(userName, insightsDict);

				App.IsLoggedIn = true;

				if (Device.OS == TargetPlatform.iOS)
					await Navigation.PopAsync();
				else {
					await Navigation.PushAsync(new FirstPage(), false);
					Navigation.RemovePage(this);
				}
			}
			else {
				var signUp = await DisplayAlert("Invalid Login", "Sorry, we didn't recoginize the username or password. Feel free to sign up for free if you haven't!", "Sign up", "Try again");

				if (signUp)
				{
					await Navigation.PushModalAsync(new NewUserSignUpPage());

					Xamarin.Insights.Track("NewUserSignUp", new Dictionary<string, string> {
						{ "ActionPoint", "System Prompt" },
					});
				}
			}
		}

		public override void NewUserSignUp()
		{
			base.NewUserSignUp();
			Navigation.PushModalAsync(new NewUserSignUpPage());
		}

		bool isInitialized = false;

		protected override void OnAppearing()
		{
			base.OnAppearing();

			//Need bug fixed on Material Design for PopToRootAsync() 
			//https://bugzilla.xamarin.com/show_bug.cgi?id=36907
			if (!isInitialized)
			{
				if (Device.OS == TargetPlatform.iOS)
					Navigation.InsertPageBefore(new FirstPage(), this);

				isInitialized = true;
			}
		}

		public override void RunAfterAnimation()
		{
			base.RunAfterAnimation();

			if (App.UserName != null)
				SetUsernameEntry(App.UserName);
		}
	}
}