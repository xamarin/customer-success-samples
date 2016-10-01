using System;

using Android.OS;
using Android.App;
using Android.Widget;

namespace CheckBoxSampleApp
{
	[Activity(Label = "CheckBoxSampleApp", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Material.Light.DarkActionBar")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			var checkBox1 = FindViewById<CheckBox>(Resource.Id.CheckBox1);
			var checkBox2 = FindViewById<CheckBox>(Resource.Id.CheckBox2);
			var checkBox3 = FindViewById<CheckBox>(Resource.Id.CheckBox3);

			checkBox1.Click += HandleCheckBoxClick;
			checkBox2.Click += HandleCheckBoxClick;
			checkBox3.Click += HandleCheckBoxClick;
		}

		void HandleCheckBoxClick(object sender, EventArgs e)
		{
			var checkBox = sender as CheckBox;

			if (checkBox?.ContentDescription == null)
				return;

			var checkBoxNumber = int.Parse(checkBox?.ContentDescription.Substring(8));
			checkBox.Text = checkBox.Checked ? $"Check Box {checkBoxNumber} is Checked" : $"Check Box {checkBoxNumber} is Unchecked";
		}
	}
}

