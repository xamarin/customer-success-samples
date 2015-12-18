using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using DrawColorCircle;
using DrawColorCircle.iOS;

using CoreGraphics;
using UIKit;

[assembly: ExportRenderer(typeof(CircleContentView),typeof(DrawColorCircleRenderer_iOS))]

namespace DrawColorCircle.iOS
{
	public class DrawColorCircleRenderer_iOS : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			var view = e.NewElement;

			var circleView = new CircleView (view.WidthRequest/2) {
				Frame = new CGRect (0, 0, (nfloat)view.WidthRequest, (nfloat)view.HeightRequest)
			};

			NativeView.Add (circleView);

		}
	}
}