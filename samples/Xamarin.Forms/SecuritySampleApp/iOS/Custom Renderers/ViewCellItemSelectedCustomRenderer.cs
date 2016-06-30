using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using SecuritySampleApp.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(ViewCellItemSelectedCustomRenderer))]

namespace SecuritySampleApp.iOS
{
    public class ViewCellItemSelectedCustomRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}