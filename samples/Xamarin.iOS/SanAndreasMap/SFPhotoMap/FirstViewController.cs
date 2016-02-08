using System;
using Google.Maps;
using UIKit;
using CoreGraphics;
using CoreLocation;
using System.IO;

namespace SanAndreasMap
{
	public partial class FirstViewController : UIViewController
	{

		MapView mapView;

		public FirstViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void LoadView()
		{
			base.LoadView ();

			var camera = CameraPosition.FromCamera (35.95, -120.50, 11);

			mapView = MapView.FromCamera(CGRect.Empty, camera);
			mapView.MyLocationEnabled = true;
			mapView.MapType = MapViewType.Terrain;

			//Load all the markers in 
			LoadMarkers();
			View = mapView;

		}

		public string[] ReadGPSCoords()
		{
			string[] text = System.IO.File.ReadAllLines ("GPSCoords.txt");


			return text;

		}

		public void LoadMarkers()
		{
			CLLocationCoordinate2D coord;

			string[] coordList = ReadGPSCoords ();

			foreach (string s in coordList) {

				if (string.IsNullOrEmpty (s) == false) {

					string[] coordPair = s.Split(',');

					if (coordPair.Length > 0) {
						
						var longitude = coordPair [0];
						var lat = coordPair [1];

						coord = new CLLocationCoordinate2D ( Convert.ToDouble(lat), Convert.ToDouble(longitude));
						var marker = Marker.FromPosition (coord);					
						marker.Map = mapView;
					}

				}

			}
				


		}


	}
}

