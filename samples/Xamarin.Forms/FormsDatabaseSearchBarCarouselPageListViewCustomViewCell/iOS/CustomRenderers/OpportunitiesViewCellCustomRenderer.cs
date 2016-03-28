using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using InvestmentDataSampleApp;
using InvestmentDataSampleApp.iOS;

[assembly: ExportRenderer(typeof(OpportunitiesViewCell), typeof(OpportunitiesViewCellCustomRenderer))]
namespace InvestmentDataSampleApp.iOS
{
	public class OpportunitiesViewCellCustomRenderer : ViewCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);

			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;

			return cell;
		}
	}
}

