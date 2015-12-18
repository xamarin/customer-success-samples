using System;
using System.Drawing;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using DrawColorCircle;
using DrawColorCircle.Droid;

using Android.Graphics;

[assembly: ExportRenderer(typeof(CircleContentView),typeof(DrawColorCircleRenderer_Android))]

namespace DrawColorCircle.Droid
{
	public class DrawColorCircleRenderer_Android : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			var formsView = e.NewElement;

			float viewWidth = (float)(formsView.WidthRequest * Resources.DisplayMetrics.Density);
			float viewHeight = (float)(formsView.HeightRequest * Resources.DisplayMetrics.Density);
			RectF rect = new RectF (0, 0, viewWidth, viewHeight);

			Android.Views.View circleView = new CircleView (Context, rect);

			SetNativeControl (circleView);
		}
	}
}