using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps.Android;

using FormsMapClickPopUp;
using FormsMapClickPopUp.Droid.CustomMap_Droid;

using Android.Gms.Maps;

[assembly:ExportRenderer(typeof(CustomMap),typeof(MapCustomRenderer))]

namespace FormsMapClickPopUp.Droid.CustomMap_Droid
{
	public class MapCustomRenderer : MapRenderer, IOnMapReadyCallback
	{
		GoogleMap googleMap;
		CustomMap formsMap;

		protected override void OnElementChanged (Xamarin.Forms.Platform.Android.ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				formsMap = e.NewElement as CustomMap;
				((MapView)Control).GetMapAsync (this);
			}
		}

		public void OnMapReady(GoogleMap googleMap)
		{
			googleMap = googleMap;
			googleMap.SetInfoWindowAdapter (new CustomInfoWindow(Context, this, formsMap.CustomPins));
		}
	}
}