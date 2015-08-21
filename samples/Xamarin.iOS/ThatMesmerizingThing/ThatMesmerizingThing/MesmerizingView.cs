using System;

using CoreGraphics;
using UIKit;
using CoreAnimation;
using Foundation;

namespace ThatMesmerizingThing
{
	public class MesmerizingView : UIView
	{
		public nfloat Position { get; set; } = 0.0f;
		public nfloat PositionIncrement { get; set; } = 0.25f;
		public CGSize CanvasSize { get; private set; } 

		private nfloat Scale { get; } = UIScreen.MainScreen.Scale;
		private CGPath Path { get; set; } = new CGPath ();

		private CADisplayLink _displayLink;

		private nfloat _r;
		private nfloat _st;
		private nfloat _et;


		public MesmerizingView (CGRect frame)
		{
			Frame = frame;
			CanvasSize = new CGSize (Frame.Width, Frame.Height);
			BackgroundColor = UIColor.White;
			ClearsContextBeforeDrawing = true;

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
			_displayLink.FrameInterval = 0;
			_displayLink.AddToRunLoop (NSRunLoop.Current, NSRunLoopMode.Default);
		}


		private void CalculateThatMesmerizingThing ()
		{
			for (int x = 0; x < 10; x++) 
			{
				_r = x * 10 + 4;
				_st = ((Position * (x + 1)) % 200) / 100;
				_et = (_st + 1) % 2;

				SetNeedsDisplay ();

				Position = (Position + PositionIncrement) % 200;
			}

			PositionIncrement = (nfloat)(0.7f * ((100 - (Math.Abs (100 - Position))) / 100));

			if (PositionIncrement < 0.01f)
				PositionIncrement = 0.01f;
			
		}


		private void DrawThatMesmerizingThing ()
		{
			using (var ctx = UIGraphics.GetCurrentContext ())
			{
				ctx.SetLineWidth (8);

				UIColor.White.SetFill ();
				UIColor.Black.SetStroke ();

				Path.AddArc (Frame.GetMidX (), Frame.GetMidY (), _r, (nfloat)(_et * Math.PI), (nfloat)(_st * Math.PI), false);

				ctx.AddPath (Path);
				ctx.DrawPath (CGPathDrawingMode.FillStroke);
			}
		}
	}
}