using System.Reflection;

using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;

namespace AndroidUnitTestProject
{
	[Activity (Label = "AndroidUnitTestProject", MainLauncher = true)]
	public class MainActivity : TestSuiteActivity
	{
		public static Activity _activity;
		public static Bundle _bundle;

		protected override void OnCreate (Bundle bundle)
		{
			_activity = this;
			_bundle = bundle;

			// tests can be inside the main assembly
			AddTest (Assembly.GetExecutingAssembly ());
			// or in any reference assemblies
			// AddTest (typeof (Your.Library.TestClass).Assembly);
			// Once you called base.OnCreate(), you cannot add more assemblies.
			base.OnCreate (bundle);
		}
	}
}

