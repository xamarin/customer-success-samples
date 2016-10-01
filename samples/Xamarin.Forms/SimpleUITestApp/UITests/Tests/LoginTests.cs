using Xamarin.UITest;

using NUnit.Framework;

namespace SimpleUITestApp.UITests
{
	[Category("LoginTests")]
	public class LoginTests : BaseTest
	{
		public LoginTests(Platform platform)
			: base(platform)
		{
		}

		public override void BeforeEachTest()
		{
			base.BeforeEachTest();

			if (app is Xamarin.UITest.iOS.iOSApp)
			{
				app.Invoke("xtcAgent:", "");
				app.Invoke("clearKeyChain:", "");
			}
		}

		[Test]
		public void CreateNewUserAndLogin()
		{
			//Arrange
			var username = "Brandon";
			var password = "test";
			var expectedFirstPageTitle = "First Page";

			//Act
			LoginPage.PressSignUpButton();
			NewUserSignUpPage.CreateNewUserWithPassword(username, password);
			LoginPage.LoginWithUsernamePassword(username, password);

			//Assert
			var actualFirstPageTitle = FirstPage.GetTitle();
			Assert.AreEqual(expectedFirstPageTitle, actualFirstPageTitle);
		}

		[Test]
		public void CreateNewUserAndUnsuccessfullyLogin()
		{
			//Arrange
			var username = "Brandon";
			var password = "test";
			var incorrectPassword = "incorrect";

			//Act
			LoginPage.PressSignUpButton();
			NewUserSignUpPage.CreateNewUserWithPassword(username, password);
			LoginPage.LoginWithUsernamePassword(username, incorrectPassword);
			LoginPage.TapTryAgainDialog();

			//Assert
			Assert.IsTrue(app.Query("Login").Length > 0);
		}

		[Test]
		public void TryLoginWithNoPasswordEntered()
		{
			//Arrange
			var username = "Brandon";

			//Act
			LoginPage.EnterUsername(username);
			LoginPage.PressLoginButton();
			LoginPage.TapOkayOnErrorDialog();

			//Assert
			Assert.IsTrue(app.Query("Login").Length > 0);
		}

		[Test]
		public void TryLoginWithNoUsernameEntered()
		{
			//Arrange
			var password = "xamarin";

			//Act	
			LoginPage.EnterPassword(password);
			LoginPage.PressLoginButton();
			LoginPage.TapOkayOnErrorDialog();

			//Assert
			Assert.IsTrue(app.Query("Login").Length > 0);
		}
	}
}