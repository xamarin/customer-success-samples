using NUnit.Framework;

using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace CheckBoxSampleApp.UITest
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			app = ConfigureApp
				.Android
				.InstalledApp("com.minnick.checkboxsampleapp")
				.PreferIdeSettings()
				.StartApp();

			app.Screenshot("First screen.");
		}

		[Ignore]
		[Test]
		public void ReplTest()
		{
			app.Repl();
		}

		[TestCase("CheckBox1")]
		[TestCase("CheckBox2")]
		[TestCase("CheckBox3")]
		[Test]
		public void ToggleIndividualCheckBox(string textBoxContentDescription)
		{
			//Arrange
			bool isCheckBoxChecked;

			//Act
			ToggleCheckBox(textBoxContentDescription);

			//Assert
			isCheckBoxChecked = IsCheckBoxChecked(textBoxContentDescription);
			Assert.IsTrue(isCheckBoxChecked, "The check box is not checked");

			//Act
			ToggleCheckBox(textBoxContentDescription);

			//Assert
			isCheckBoxChecked = IsCheckBoxChecked(textBoxContentDescription);
			Assert.IsFalse(isCheckBoxChecked, "The check box is not checked");
		}

		[TestCase("CheckBox1", true)]
		[TestCase("CheckBox2", true)]
		[TestCase("CheckBox3", true)]
		[TestCase("CheckBox1", false)]
		[TestCase("CheckBox2", false)]
		[TestCase("CheckBox3", false)]
		[Test]
		public void SetIndividualCheckBox(string textBoxContentDescription, bool isChecked)
		{
			//Arrange
			bool isCheckBoxChecked;

			//Act
			SetCheckBox(textBoxContentDescription, isChecked);

			//Assert
			isCheckBoxChecked = IsCheckBoxChecked(textBoxContentDescription);
			Assert.AreEqual(isChecked, isCheckBoxChecked);
		}

		[Test]
		public void ToggleAllCheckBoxes()
		{
			//Arrange
			object[] isCheckBoxCheckedArray;

			//Act
			app.Query(x => x.Class("CheckBox").Invoke("performClick"));
			app.Screenshot("All CheckBoxes Checked");

			//Assert
			isCheckBoxCheckedArray = app.Query(x => x.Class("CheckBox").Invoke("isChecked"));
			for (int i = 0; i < isCheckBoxCheckedArray.Length; i++)
				Assert.IsTrue((bool)isCheckBoxCheckedArray[i], $"Check box {i} is not checked");

			//Act
			app.Query(x => x.Class("CheckBox").Invoke("performClick"));
			app.Screenshot("All CheckBoxes Unchecked");

			//Assert
			isCheckBoxCheckedArray = app.Query(x => x.Class("CheckBox").Invoke("isChecked"));
			for (int i = 0; i < isCheckBoxCheckedArray.Length; i++)
				Assert.False((bool)isCheckBoxCheckedArray[i], $"Check box {i} is checked");
		}

		void ToggleCheckBox(string textBoxContentDescription)
		{
			app.Query(x => x.Marked(textBoxContentDescription).Invoke("performClick"));
			app.Screenshot($"Toggled {textBoxContentDescription}");
		}

		bool IsCheckBoxChecked(string textBoxContentDescription)
		{
			return (bool)app.Query(x => x.Marked(textBoxContentDescription).Invoke("isChecked"))[0];
		}

		void SetCheckBox(string textBoxContentDescription, bool IsChecked)
		{
			app.Query(x => x.Marked(textBoxContentDescription).Invoke("setChecked", IsChecked));
			app.Screenshot($"Set {textBoxContentDescription} to {IsChecked}");
		}
	}
}

