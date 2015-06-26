using System;
using System.Collections.Generic;

using Foundation;
using UIKit;

using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.iOS
{
	public class UserTableViewSource : UITableViewSource
	{
		private IList<User> _users;
		private string CellIdentifier = "CellIdentifier";

		public UserTableViewSource (IList<User> users)
		{
			_users = users;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _users.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);
			var user = _users[indexPath.Row];

			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier);

			cell.TextLabel.Text = user.Name;

			return cell;
		}
	}
}