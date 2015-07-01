using System;
using UIKit;
using Foundation;

namespace OnKeyboardAnimation
{
	public class BaseViewController : UIViewController
	{
		protected UITapGestureRecognizer _tapGesture;

		protected NSObject WillShowObserver { get; set; }

		protected NSObject WillHideObserver { get; set; }

		protected bool KeyboardVisible { get; set; }

		private UIKit.UIGestureRecognizer.Token _targetToken;

		public BaseViewController () 
		{
		}

		public BaseViewController (IntPtr handle) : base (handle) 
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			RegisterTapGestureRecognizer ();
			RegisterWithKeyboardNotifications ();
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			RemoveTapGestureRecognzer ();
			RemoveKeyboardNotifications ();
		}
			
		protected void RegisterWithKeyboardNotifications ()
		{
			WillShowObserver = UIKeyboard.Notifications.ObserveWillShow ((sender, e) => OnKeyboardNotification (e));
			WillHideObserver = UIKeyboard.Notifications.ObserveWillHide ((sender, e) => OnKeyboardNotification (e));
		}

		protected void RemoveKeyboardNotifications ()
		{
			if (WillShowObserver != null) 
			{
				WillShowObserver.Dispose ();
				WillShowObserver = null;
			}

			if (WillHideObserver != null) 
			{
				WillHideObserver.Dispose ();
				WillHideObserver = null;
			}
		}

		protected void RegisterTapGestureRecognizer ()
		{
			_tapGesture = new UITapGestureRecognizer ();

			_tapGesture.NumberOfTapsRequired = 1;
			_tapGesture.NumberOfTouchesRequired = 1;

			_targetToken = _tapGesture.AddTarget (EndTarget);

			View.AddGestureRecognizer (_tapGesture);
		}

		protected void RemoveTapGestureRecognzer ()
		{
			_tapGesture.RemoveTarget (_targetToken);
			View.RemoveGestureRecognizer (_tapGesture);
		}

		private void EndTarget ()
		{
			if (KeyboardVisible)
				View.EndEditing (true);
		}

		private void OnKeyboardNotification (UIKeyboardEventArgs e)
		{
			KeyboardVisible = e.Notification.Name == UIKeyboard.WillShowNotification;
		}
	}
}