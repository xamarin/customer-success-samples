using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.iOS;

using FormsMapClickPopUp;
using FormsMapClickPopUp.iOS;
using FormsMapClickPopUp.iOS.CustomMap_iOS;

using MapKit;
using UIKit;
using CoreGraphics;
using CoreLocation;
using System.Collections.Generic;

[assembly:ExportRenderer(typeof(CustomMap),typeof(MapCustomRenderer))]

namespace FormsMapClickPopUp.iOS.CustomMap_iOS
{
	public class MapCustomRenderer : MapRenderer
	{
		protected override void OnElementChanged (Xamarin.Forms.Platform.iOS.ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				var formsMap = (CustomMap)e.NewElement;
				var nativeMap = Control as MKMapView;
				nativeMap.Delegate = new CustomMapDelegate (formsMap.CustomPins as List<CustomPin>);
			}
		}
	}
}