using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using customersuccess52;
using customersuccess52.iOS;

[assembly:ExportCell(typeof(DisclosureCell),typeof(DisclosureCellRenderer))]

namespace customersuccess52.iOS
{
	public class DisclosureCellRenderer : ViewCellRenderer
	{
		public override UIKit.UITableViewCell GetCell (Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{
			var cell = base.GetCell (item,reusableCell, tv);
			var discItem = item as DisclosureCell;

			if (discItem.StyleId == "SearchControls") {
				cell.Accessory = UIKit.UITableViewCellAccessory.DisclosureIndicator;
			} else if (discItem.StyleId == "Details" && discItem.IsSelected) {
				cell.Accessory = UIKit.UITableViewCellAccessory.Checkmark;
			} else {
				cell.AccessoryView = new UIKit.UIView (new CoreGraphics.CGRect (0, 0, 20, cell.Bounds.Height));
			}

			return cell;
		}
	}
}