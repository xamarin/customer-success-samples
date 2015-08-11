using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using FormsCustomWebViewClient.iOS;

using UIKit;

[assembly:ExportRenderer(typeof(WebView),typeof(WebViewCustomRenderer))]

namespace FormsCustomWebViewClient.iOS
{
	public class WebViewCustomRenderer : WebViewRenderer
	{
		Xamarin.Forms.WebView formsWebView;

		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				formsWebView = e.NewElement as WebView;
				Delegate = new CustomWebViewDelegate (formsWebView);
			}
		}
	}

	public class CustomWebViewDelegate : UIWebViewDelegate
	{
		Xamarin.Forms.WebView formsWebView;
		public event EventHandler<WebNavigatedEventArgs> Navigated;
		WebNavigationEvent lastEvent;

		public CustomWebViewDelegate(Xamarin.Forms.WebView webView)
		{
			formsWebView = webView;
			Navigated += App.NewEventHandler;
		}

		public override void LoadingFinished (UIWebView webView)
		{
			var url = webView.Request.Url.AbsoluteUrl.ToString ();
			var args = new WebNavigatedEventArgs (lastEvent, formsWebView.Source, url, WebNavigationResult.Success);

			Navigated (formsWebView, args);
		}

		public override bool ShouldStartLoad (UIWebView webView, Foundation.NSUrlRequest request, UIWebViewNavigationType navigationType)
		{
			WebNavigationEvent navEvent = WebNavigationEvent.NewPage;
			switch (navigationType) {
			case UIWebViewNavigationType.LinkClicked:
				navEvent = WebNavigationEvent.NewPage;
				break;
			case UIWebViewNavigationType.FormSubmitted:
				navEvent = WebNavigationEvent.NewPage;
				break;
			case UIWebViewNavigationType.Reload:
				navEvent = WebNavigationEvent.Refresh;
				break;
			case UIWebViewNavigationType.FormResubmitted:
				navEvent = WebNavigationEvent.NewPage;
				break;
			case UIWebViewNavigationType.Other:
				navEvent = WebNavigationEvent.NewPage;
				break;
			}

			lastEvent = navEvent;

			Console.WriteLine ("[Custom Delegate] Url: {0}", request.Url);
			Console.WriteLine ("[Custom Delegate] MainDocUrl: {0}", request.MainDocumentURL);
			return true;
		}
	}
}