using System;
using UIKit;
using CoreGraphics;
using Foundation;

namespace DraggableView
{
	[Register("DraggableView")]
	public class DraggableView : UIView
	{
		private CGPoint _startingPoint;
		private UIPanGestureRecognizer _panGestureRecognizer;

		public DraggableDirection Dragged { get; private set; }
		public nfloat SwipeThreshold { get; set; }
		public nfloat RotationAnimationDuration { get; set; }
		public nfloat ScaleStrength { get; set; }
		public nfloat RotationStrength { get; set; }

		public event EventHandler<DraggableEventArgs> OnSwipe;

		public DraggableView (IntPtr handle) : base (handle) { }

		public DraggableView () 
		{ 
			_panGestureRecognizer = new UIPanGestureRecognizer (HandleOnGestureRecognizer);

			RotationStrength = 300;
			RotationAnimationDuration = 0.85f;
			ScaleStrength = 0.85f;
			SwipeThreshold = 140;
		}

		private void HandleOnGestureRecognizer (UIPanGestureRecognizer gestureRecognizer)
		{
			// The translation of the pan gesture in the coordinate system of the specified view.
			var xTranslation = gestureRecognizer.TranslationInView (this).X;
			var yTranslation = gestureRecognizer.TranslationInView (this).Y;

			if (gestureRecognizer.State.Equals (UIGestureRecognizerState.Began)) {
				_startingPoint = Center;
			} 
			else if (gestureRecognizer.State.Equals (UIGestureRecognizerState.Changed)) {
				var rotationStrength = Math.Min (xTranslation / RotationStrength, 1);
				var rotationAngle = (nfloat)(2 * Math.PI * rotationStrength / 17);
				var scaleStrength = 1 - Math.Abs (rotationStrength) / 4;
				var scale = (nfloat)Math.Max (scaleStrength, ScaleStrength);
				var transform = CGAffineTransform.MakeRotation (rotationAngle);

				Center = new CGPoint (_startingPoint.X + xTranslation, _startingPoint.Y + yTranslation);
				Transform = CGAffineTransform.Scale (transform, scale, scale);
			} 
			else if (gestureRecognizer.State.Equals (UIGestureRecognizerState.Ended)) {
				DetermineSwipeAction (xTranslation);
				ResetView ();
			}
		}

		private void DetermineSwipeAction (nfloat xTranslation)
		{
			if (xTranslation <= -SwipeThreshold) {
				Dragged = DraggableDirection.Left;
			} else if (xTranslation >= SwipeThreshold) {
				Dragged = DraggableDirection.Right;
			} else {
				Dragged = DraggableDirection.None;
			}

			var evt = OnSwipe;

			if (evt != null)
				OnSwipe (this, new DraggableEventArgs (Dragged));
		}

		private void ResetView ()
		{
			UIView.Animate (RotationAnimationDuration, () => { 
				Center = _startingPoint;
				// The translation of the pan gesture in the coordinate system of the specified UIView.
				Transform = CGAffineTransform.MakeRotation (0);
			});
		}

		public override void WillMoveToSuperview (UIView newsuper)
		{
			AddGestureRecognizer (_panGestureRecognizer);
		}

		public override void WillRemoveSubview (UIView uiview)
		{
			RemoveGestureRecognizer (_panGestureRecognizer);
		}
	}
}