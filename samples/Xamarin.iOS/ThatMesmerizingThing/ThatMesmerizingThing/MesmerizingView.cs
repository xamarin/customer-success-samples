using System;

using Foundation;
using UIKit;
using CoreGraphics;
using CoreAnimation;

namespace ThatMesmerizingThing
{
	public class MesmerizingView : UIView
	{
		public nfloat Position { get; set; } = 0.0f;
		public nfloat PositionIncrement { get; set; } = 0.25f;

		private Dimensions[] Dimensions { get; set; } = new Dimensions [10];
		private CADisplayLink _displayLink;


		public MesmerizingView (CGRect frame)
		{
			Frame = frame;
			BackgroundColor = UIColor.White;

			SetupDisplayLink ();
		}


		public override void Draw (CGRect rect)
		{
			base.Draw (rect);

			DrawThatMesmerizingThing ();
		}


		private void SetupDisplayLink ()
		{
			_displayLink = CADisplayLink.Create (CalculateThatMesmerizingThing);
			_displayLink.AddToRunLoop (NSRunLoop.Current, NSRunLoopMode.Default);
		}


		private void StopDisplayLink ()
		{
			_displayLink.Invalidate ();
			_displayLink = null;
		}


		private void CalculateThatMesmerizingThing ()
		{
			for (var x = 0; x < 10; x++) 
			{
				Dimensions[x].R = x * 10 + 4;
				Dimensions[x].St = ((Position * (x + 1)) % 200) / 100;
				Dimensions[x].Et = (Dimensions[x].St + 1) % 2;

				Position = (Position + PositionIncrement) % 200;
			}

			PositionIncrement = (nfloat)(0.7f * ((100 - (Math.Abs (100 - Position))) / 100));

			if (PositionIncrement < 0.01f)
				PositionIncrement = 0.01f;

			SetNeedsDisplay ();
		}


		private void DrawThatMesmerizingThing ()
		{
			using (var ctx = UIGraphics.GetCurrentContext ())
			{
				ctx.SetLineWidth (8);

				UIColor.White.SetFill ();
				UIColor.Black.SetStroke ();

				for (var x = 0; x < 10; x++) 
				{
					var path = new CGPath ();
					path.AddArc (Frame.GetMidX (), Frame.GetMidY (), Dimensions[x].R, (nfloat)(Dimensions[x].Et * Math.PI), (nfloat)(Dimensions[x].St * Math.PI), false);
					ctx.AddPath (path);
				}

				ctx.DrawPath (CGPathDrawingMode.FillStroke);
			}
		}


		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);

			StopDisplayLink ();
		}
	}
}