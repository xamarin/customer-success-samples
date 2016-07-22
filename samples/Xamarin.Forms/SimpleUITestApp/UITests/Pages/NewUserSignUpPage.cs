using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SimpleUITestApp.UITests
{
	public class NewUserSignUpPage : BasePage
	{
		protected readonly Query CancelButton;
		protected readonly Query PasswordEntry;
		protected readonly Query SaveUsernameButton;
		protected readonly Query UsernameEntry;

		public NewUserSignUpPage(IApp app, Platform platform)
			: base(app, platform)
		{
			CancelButton = x => x.Marked("cancelButton");
			PasswordEntry = x => x.Marked("newPasswordEntry");
			SaveUsernameButton = x => x.Marked("saveUsernameButton");
			UsernameEntry = x => x.Marked("newUsernameEntry");
		}

		public void CreateNewUserWithPassword(string username, string password)
		{
			EnterUsername(username);
			EnterPassword(password);
			TapSave();
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

		public void TapSave()
		{
			app.Tap(SaveUsernameButton);
			app.Screenshot("Tapped Save Button");
		}

		public void TapCancel()
		{
			app.Tap(CancelButton);
			app.Screenshot("Tapped Cancel Button");
		}
	}
}