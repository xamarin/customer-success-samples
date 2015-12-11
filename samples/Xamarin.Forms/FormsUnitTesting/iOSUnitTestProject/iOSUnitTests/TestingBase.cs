using System;
using NUnit.Framework;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

namespace iOSUnitTestProject
{
	public class TestingBase
	{
		[SetUp]
		public void Init ()
		{
			Forms.Init ();
		}

		protected T GetInitializedElement<T> (View view)
			where T : class, IVisualElementRenderer
		{
			var renderer = RendererFactory.GetRenderer (view) as T;
			var parent = new UIView ();
			parent.AddSubview (renderer.NativeView);

			return renderer;
		}
	}
}