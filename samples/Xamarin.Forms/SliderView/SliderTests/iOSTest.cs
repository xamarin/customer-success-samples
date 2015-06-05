using System;
using System.IO;
using System.Reflection;

using NUnit.Framework;

using Xamarin.UITest;

namespace SliderTests
{
	[TestFixture()]
	public class iOSTest : CrossPlatformTests
	{
		public string PathToAPK { get; set; }


		[TestFixtureSetUp]
		public void TestFixtureSetup()
		{
			string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
			FileInfo fi = new FileInfo(currentFile);
			string dir = fi.Directory.Parent.Parent.Parent.FullName;
			PathToAPK = Path.Combine(dir, "iOS", "bin", "iPhoneSimulator", "Debug", "SliderView.iOS.ap");
		}

		[SetUp]
		public override void SetUp()
		{
			// an API key is required to publish on Xamarin Test Cloud for remote, multi-device testing
			app = ConfigureApp.iOS.AppBundle(PathToAPK).ApiKey("4d53270f3f6e9baade2c24927062d493").StartApp();
		}
	}
}