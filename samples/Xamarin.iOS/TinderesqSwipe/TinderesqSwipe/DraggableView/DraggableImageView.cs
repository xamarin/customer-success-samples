using System;
using UIKit;
using CoreGraphics;
using Foundation;

namespace DraggableView
{
	[Register ("DraggableImageView")]
	public sealed class DraggableImageView : DraggableView
	{
		private UIImageView _imageView;

		public DraggableImageView (IntPtr handle) : base (handle) { }

		public DraggableImageView (UIImage image, CGRect frame)
		{
			Initialize (image, frame);
		}

		private void Initialize (UIImage image, CGRect frame)
		{
			_imageView = new UIImageView (image) {
				Frame = frame,
				ContentMode = UIViewContentMode.ScaleAspectFit
			};

			AddSubview (_imageView);
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			Frame = _imageView.Frame;
		}
			
		public override void WillRemoveSubview (UIView uiview)
		{
			base.WillRemoveSubview (uiview);

			_imageView.Image.Dispose ();
			_imageView.Image = null;
		}
	}
}