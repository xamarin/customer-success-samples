using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using FormsNativeVideoPlayer.iOS;

using AVFoundation;
using Foundation;
using UIKit;
using CoreGraphics;
using AVKit;

[assembly: ExportRenderer(typeof(ContentView), typeof(VideoPlayer_CustomRenderer))]

namespace FormsNativeVideoPlayer.iOS
{
	public class VideoPlayer_CustomRenderer : ViewRenderer
	{
		//globally declare variables
		AVAsset _asset;
		AVPlayerItem _playerItem;
		AVPlayer _player;

		AVPlayerLayer _playerLayer;
		UIButton playButton;

		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			//Get the video
			//bubble up to the AVPlayerLayer
			var url = new NSUrl ("http://www.androidbegin.com/tutorial/AndroidCommercial.3gp");
			_asset = AVAsset.FromUrl (url);

			_playerItem = new AVPlayerItem (_asset);

			_player = new AVPlayer (_playerItem);

			_playerLayer = AVPlayerLayer.FromPlayer (_player);

			//Create the play button
			playButton = new UIButton ();
			playButton.SetTitle ("Play Video", UIControlState.Normal);
			playButton.BackgroundColor = UIColor.Gray;

			//Set the trigger on the play button to play the video
			playButton.TouchUpInside += (object sender, EventArgs arg) => {
				_player.Play();
			};
		}
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			//layout the elements depending on what screen orientation we are. 
			if (DeviceHelper.iOSDevice.Orientation == UIDeviceOrientation.Portrait) {
				playButton.Frame = new CGRect (0, NativeView.Frame.Bottom - 50, NativeView.Frame.Width, 50);
				_playerLayer.Frame = NativeView.Frame;
				NativeView.Layer.AddSublayer (_playerLayer);
				NativeView.Add (playButton);
			} else if (DeviceHelper.iOSDevice.Orientation == UIDeviceOrientation.LandscapeLeft || DeviceHelper.iOSDevice.Orientation == UIDeviceOrientation.LandscapeRight) {
				_playerLayer.Frame = NativeView.Frame;
				NativeView.Layer.AddSublayer (_playerLayer);
				playButton.Frame = new CGRect (0, 0, 0, 0);
			}
		}
	}
}