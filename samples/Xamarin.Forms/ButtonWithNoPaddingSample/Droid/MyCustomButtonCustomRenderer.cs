using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ButtonWithNoPaddingSample;
using ButtonWithNoPaddingSample.Droid;

[assembly: ExportRenderer(typeof(MyCustomButton), typeof(MyCustomButtonCustomRenderer))]
namespace ButtonWithNoPaddingSample.Droid
{
	public class MyCustomButtonCustomRenderer : ButtonRenderer
	{

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			var nativeButton = (global::Android.Widget.Button)this.Control;
			nativeButton.SetPadding (0, 0, 0, 0);
		}
	}
}