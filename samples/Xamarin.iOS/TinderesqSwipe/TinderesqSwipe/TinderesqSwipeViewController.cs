using System;

using UIKit;
using CoreGraphics;
using DraggableView;

namespace TinderesqSwipe
{
	public partial class TinderesqSwipeViewController : UIViewController
	{
		public DraggableImageView DraggableImageView { get; set; }

		public TinderesqSwipeViewController (IntPtr handle) : base (handle) { }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			DraggableImageView = new DraggableImageView (UIImage.FromFile ("jondavis.jpg"), new CGRect (5, 20, 300, 354));
			DraggableImageView.OnSwipe += HandleOnSwipe;

			View.AddSubview (DraggableImageView);
		}

		private void HandleOnSwipe (object sender, DraggableEventArgs evt)
		{
			if (!evt.Dragged.Equals (DraggableDirection.None)) {
				var message = evt.Dragged.Equals (DraggableDirection.Left) ? "You Chose Poorly" : "You Swiped Right";
				new UIAlertView ("Swiped", message, null, "OK", "OK").Show ();
			}
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			DraggableImageView.OnSwipe -= HandleOnSwipe;
		}
	}
}