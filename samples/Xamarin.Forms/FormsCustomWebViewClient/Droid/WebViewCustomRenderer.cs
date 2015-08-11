using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using FormsCustomWebViewClient.Droid;

using Android.Webkit;

[assembly:ExportRenderer(typeof(Xamarin.Forms.WebView),typeof(WebViewCustomRenderer))]

namespace FormsCustomWebViewClient.Droid
{
	public class WebViewCustomRenderer : WebViewRenderer
	{
		Xamarin.Forms.WebView formsWebView;

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.WebView> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				formsWebView = e.NewElement;
				Control.SetWebViewClient (new CustomWebViewClient(formsWebView));
			}
		}
	}

	public class CustomWebViewClient : WebViewClient
	{
		Xamarin.Forms.WebView formsWebView;
		public event EventHandler<WebNavigatedEventArgs> Navigated;

		public CustomWebViewClient(Xamarin.Forms.WebView webView)
		{
			formsWebView = webView;
			Navigated += App.NewEventHandler;
		}

		public override WebResourceResponse ShouldInterceptRequest (Android.Webkit.WebView view, IWebResourceRequest request)
		{
			Console.WriteLine ("[Custom Delegate] Url: {0}", request.Url);

			return base.ShouldInterceptRequest (view, request);
		}

		public override void OnPageFinished (Android.Webkit.WebView view, string url)
		{
			var source = new UrlWebViewSource{ Url = url };
			var args = new WebNavigatedEventArgs (WebNavigationEvent.NewPage, source, url, WebNavigationResult.Success);

			Navigated (formsWebView, args);
			base.OnPageFinished (view, url);
		}
	}
}