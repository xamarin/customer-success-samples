using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using TabbedPageDemo;
using TabbedPageDemo.Droid;

[assembly:ExportRenderer(typeof(ListView),typeof(ListViewCustomRenderer))]

namespace TabbedPageDemo.Droid
{
	public class ListViewCustomRenderer : ListViewRenderer
	{
		public override bool OnInterceptTouchEvent (Android.Views.MotionEvent ev)
		{
			return true;
		}
	}
}