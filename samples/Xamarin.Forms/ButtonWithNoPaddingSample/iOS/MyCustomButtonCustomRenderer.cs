using System;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using ButtonWithNoPaddingSample;
using ButtonWithNoPaddingSample.iOS;

[assembly: ExportRenderer(typeof(MyCustomButton), typeof(MyCustomButtonCustomRenderer))]
namespace ButtonWithNoPaddingSample.iOS
{
	public class MyCustomButtonCustomRenderer : ButtonRenderer
	{

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			var nativeButton = (UIButton)this.Control;

			nativeButton.TitleEdgeInsets = UIEdgeInsets.Zero;
		}
	}
}

