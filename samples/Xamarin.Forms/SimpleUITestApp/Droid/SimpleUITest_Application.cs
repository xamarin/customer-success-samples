using System;

using Android.App;
using Android.Runtime;

using Xamarin;

namespace SimpleUITestApp.Droid
{
	//You can specify additional application information in this attribute
	[Application]

	public class SimpleUITest_Application : Application
	{
		public SimpleUITest_Application(IntPtr handle, JniHandleOwnership transer)
		  : base(handle, transer)
		{
		}

		public override void OnCreate()
		{
			base.OnCreate();

			Insights.Initialize(Insights_Constants.INSIGHTS_API_KEY, this);

			Insights.HasPendingCrashReport += (sender, isStartupCrash) =>
			{
				if (isStartupCrash)
				{
					Insights.PurgePendingCrashReports().Wait();
				}
			};
		}
	}
}