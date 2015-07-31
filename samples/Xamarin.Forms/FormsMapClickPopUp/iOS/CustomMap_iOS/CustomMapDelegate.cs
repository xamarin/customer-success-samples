using System;
using System.Collections.Generic;

using MapKit;
using UIKit;
using CoreGraphics;

using Xamarin.Forms.Maps;
using FormsMapClickPopUp.iOS.CustomMap_iOS.PinViews;

namespace FormsMapClickPopUp.iOS.CustomMap_iOS
{
	public class CustomMapDelegate : MKMapViewDelegate
	{
		UIView customPinView;
		List<CustomPin> _pins;

		public CustomMapDelegate(List<CustomPin> pins){
			_pins = pins;
		}

		public override MKAnnotationView GetViewForAnnotation (MKMapView mapView, IMKAnnotation annotation)
		{
			MKAnnotationView annotationView = null;
			MKPointAnnotation anno = null;

			if (annotation is MKUserLocation) {
				return null; 
			} else {
				anno = annotation as MKPointAnnotation;
			}

			string identifier = GetIdentifier (anno);

			if (identifier == "")
				throw new Exception ("No Identifier found for pin");

			annotationView = mapView.DequeueReusableAnnotation (identifier);

			if (annotationView == null)
				annotationView = new CustomMKPinAnnotationView (annotation, identifier);

			//This removes the bubble that pops up with the title and everything
			((CustomMKPinAnnotationView)annotationView).FormsIdentifier = identifier;
			annotationView.CanShowCallout = false;

			return annotationView;
		}


		public override void DidSelectAnnotationView (MKMapView mapView, MKAnnotationView view)
		{
			var customView = view as CustomMKPinAnnotationView;

			customPinView = new UIView();

			if (customView.FormsIdentifier == "Xamarin") {
				customPinView = new XamarinPinView ();
				customPinView.Center = new CGPoint (0, - (view.Frame.Height + 15));
				view.AddSubview (customPinView);
			} else if (customView.FormsIdentifier == "Train") {
				customPinView = new TrainPinView ();
				customPinView.Center = new CGPoint (0, - (view.Frame.Height + 15));
				view.AddSubview (customPinView);
			}
		}

		public override void DidDeselectAnnotationView (MKMapView mapView, MKAnnotationView view)
		{
			if (!view.Selected) {
				customPinView.RemoveFromSuperview ();
			}
		}

		string GetIdentifier(MKPointAnnotation annotation)
		{
			Position annotationPosition = new Position (annotation.Coordinate.Latitude, annotation.Coordinate.Longitude);
			foreach (var pin in _pins) {
				if (pin.FormsPin.Position == annotationPosition)
					return pin.Identifier;	
			}
			return "";
		}
	}
}