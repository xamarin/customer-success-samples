using System;
using System.IO;
using System.Reflection;

using NUnit.Framework;

using Xamarin.UITest;

namespace SliderTests
{
	[TestFixture()]
	public class AndroidTest : CrossPlatformTests
	{
		public string PathToAPK { get; set; }


		[TestFixtureSetUp]
		public void TestFixtureSetup()
		{
			string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
			FileInfo fi = new FileInfo(currentFile);
			string dir = fi.Directory.Parent.Parent.Parent.FullName;
			// update the project name (Android) and output filename (UITestDemo.Android) for each app
			PathToAPK = Path.Combine(dir, "Droid", "bin", "Release", "SliderView.Droid-Signed.apk");
		}

		[SetUp]
		public override void SetUp()
		{
			// an API key is required to publish on Xamarin Test Cloud for remote, multi-device testing
			app = ConfigureApp.Android.ApkFile(PathToAPK).ApiKey("4d53270f3f6e9baade2c24927062d493").StartApp();
		}
	}
}