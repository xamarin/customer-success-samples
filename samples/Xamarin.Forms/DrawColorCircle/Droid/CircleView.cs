using System;

using Android.Views;
using Android.Content;
using Android.Graphics;

namespace DrawColorCircle.Droid
{
	public class CircleView : View
	{
		RectF _rect;

		public CircleView(Context context, RectF rect)
			: base(context)
		{
			_rect = rect;
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);

			Paint paint = new Paint {
				Color = Android.Graphics.Color.Blue
			};
			paint.SetStyle(Paint.Style.Fill);
			canvas.DrawArc (_rect, 0, 300, true, paint);
		}
	}
}