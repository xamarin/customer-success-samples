using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SimpleUITestApp.UITests
{
	public class LoginPage : BasePage
	{
		protected readonly Query ForgotPasswordButton;
		protected readonly Query LoginButton;
		protected readonly Query PasswordEntry;
		protected readonly Query RememberMeSwitch;
		protected readonly Query SignUpButton;
		protected readonly Query UsernameEntry;

		public LoginPage(IApp app, Platform platform)
			: base(app, platform)
		{
			ForgotPasswordButton = x => x.Marked("forgotPasswordButton");
			LoginButton = x => x.Marked("loginButton");
			PasswordEntry = x => x.Marked("passwordEntry");
			RememberMeSwitch = x => x.Marked("saveUsernameSwitch");
			SignUpButton = x => x.Marked("newUserButton");
			UsernameEntry = x => x.Marked("usernameEntry");
		}

		public void LoginWithUsernamePassword(string username, string password)
		{
			
			EnterUsername(username);
			EnterPassword(password);
			PressLoginButton();
		}

		public void EnterUsername(string username)
		{
			app.Tap(UsernameEntry);
			app.ClearText();
			app.ClearText();
			app.EnterText(username);
			app.DismissKeyboard();
			app.Screenshot($"Entered Username: {username}");
		}

		public void EnterPassword(string password)
		{
			app.Tap(PasswordEntry);
			app.ClearText();
			app.ClearText();
			app.EnterText(password);
			app.DismissKeyboard();
			app.Screenshot($"Entered Password: {password}");
		}

		public void PressSignUpButton()
		{
			app.Tap(SignUpButton);
			app.Screenshot("Tapped Sign Up Button");
		}

		public void PressForgotPasswordButton()
		{
			app.Tap(ForgotPasswordButton);
			app.Screenshot("Tapped Forgot Password Button");
		}

		public void PressLoginButton()
		{
			app.Tap(LoginButton);
			app.Screenshot("Tapped Login Button");
		}

		public void SignUpNewUserFromDialog()
		{
			LoginWithUsernamePassword("incorrectUserName","incorrectPassword");
			TapSignUpFromDialog();
		}

		public void TapSignUpFromDialog()
		{
			app.WaitForElement("Sign up");
			app.Tap("Sign up");
			app.Screenshot("Tapped Sign Up Button From Pop Up Dialog");
		}

		public void TapTryAgainDialog()
		{
			app.Tap("Try again");
			app.Screenshot("Tapped Try Again Button From Pop Up Dialog");
		}

		public void TapOkayOnErrorDialog()
		{
			app.Tap("Okay");
			app.Screenshot("Tapped Okay on Error Dialog");
		}

        public void WaitForLoginScreen()
        {
            app.WaitForElement(LoginButton);
        }
	}
}