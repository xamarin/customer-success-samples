using System;

using UIKit;
using CoreGraphics;

using AdvancedUser.DemoPCL;

namespace AdvancedUser.iOS
{
	public partial class ViewController : UIViewController
	{
		private UserRepository _userRepository;

		public ViewController (IntPtr handle) : base (handle) { }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_userRepository = new UserRepository (new iOIFileSystem ());

			var results = _userRepository.GetAll ();
			var tableView = new UITableView (new CGRect (40, 0, View.Bounds.Width, View.Bounds.Height)) {
				WeakDataSource = new UserTableViewSource (results)
			};

			Add (tableView);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}