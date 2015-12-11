using System;

using UIKit;
using CoreGraphics;

namespace DrawColorCircle.iOS
{
	public class CircleView : UIView
	{
		nfloat _radius;

		public CircleView (double radius)
		{
			BackgroundColor = UIColor.Clear;
			_radius = (nfloat)radius;
		}

		public override void Draw (CGRect rect)
		{
			base.Draw (rect);

			CGContext context = UIGraphics.GetCurrentContext(); 

			CGRect bounds = rect;
			CGPoint center = new CGPoint ();
			center.X = (nfloat)(bounds.Size.Width / 2.0);
			center.Y = (nfloat)(bounds.Size.Height / 2.0);

			context.SaveState ();
			context.SetFillColor (UIColor.Blue.CGColor);

			context.AddArc (center.X, center.Y, _radius, 0, GetRadians(300), false);
			context.AddLineToPoint (center.X, center.Y);
			context.AddLineToPoint (rect.Width, center.Y);

			context.DrawPath (CGPathDrawingMode.Fill);
		}

		static nfloat GetRadians(double degrees)
		{
			return (nfloat)(degrees * (Math.PI / 180));
		}
	}
}