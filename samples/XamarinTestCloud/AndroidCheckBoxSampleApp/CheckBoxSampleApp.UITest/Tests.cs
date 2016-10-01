using System;
using NUnit.Framework;

using Xamarin.UITest;
using Xamarin.UITest.Android;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Queries;

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

		[Test]
		public void VerifyButtonClick_VerifyButtonColor_VerifyTextViewColor()
		{
			//Arrange
			var expectedButtonTextColorAsInt = ConvertAndroidDrawingHexColorToInt("#ef4444");
			var expectedTextViewTextColorAsInt = ConvertAndroidDrawingHexColorToInt("#ef4444");
			var expectedTextViewText = "1 Check Box Is Checked";

			//Act
			ToggleCheckBox("CheckBox1");
			app.Tap(x => x.Marked("Button1"));
			app.WaitForElement(x => x.Marked("TextView1"));

			//Assert
			var actualButtonColorAsInt = GetHexColorAsInt("Button1");
			var actualTextViewTextColorAsInt = GetHexColorAsInt("TextView1");
			var actualTextViewText = app.Query(x => x.Marked("TextView1"))[0]?.Text;

			Assert.AreEqual(expectedButtonTextColorAsInt, actualButtonColorAsInt);
			Assert.AreEqual(expectedTextViewTextColorAsInt, actualTextViewTextColorAsInt);
			Assert.AreEqual(expectedTextViewText, actualTextViewText);
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

		void ToggleCheckBox(string checkBoxContentDescription)
		{
			app.Query(x => x.Marked(checkBoxContentDescription).Invoke("performClick"));
			app.Screenshot($"Toggled {checkBoxContentDescription}");
		}

		bool IsCheckBoxChecked(string textBoxContentDescription)
		{
			return (bool)app.Query(x => x.Marked(textBoxContentDescription).Invoke("isChecked"))[0];
		}

		void SetCheckBox(string checkBoxContentDescription, bool IsChecked)
		{
			app.Query(x => x.Marked(checkBoxContentDescription).Invoke("setChecked", IsChecked));
			app.Screenshot($"Set {checkBoxContentDescription} to {IsChecked}");
		}

		int GetHexColorAsInt(string contentDescription)
		{
			return int.Parse(app.Query(x => x.Marked(contentDescription).Invoke("getCurrentTextColor"))[0]?.ToString());
		}

		int ConvertAndroidDrawingHexColorToInt(string colorStringAsHex)
		{
			if (!colorStringAsHex.Substring(0, 1).Equals("#") || colorStringAsHex.Length != 7)
				throw new Exception("Invalid Hex String. Color string must start with \"#\" and be followed by 6 hexadecimal characters");

			return int.Parse(app.Invoke("GetColorAsInt", colorStringAsHex).ToString());
		}
	}
}

