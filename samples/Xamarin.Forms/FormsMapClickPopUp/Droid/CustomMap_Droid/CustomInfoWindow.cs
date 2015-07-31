using System;
using System.Collections.Generic;

using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Widget;
using Android.App;

using Java.IO;
using Xamarin.Forms.Maps;

namespace FormsMapClickPopUp.Droid.CustomMap_Droid
{
	public class CustomInfoWindow : Java.Lang.Object, GoogleMap.IInfoWindowAdapter
	{
		Context _context;
		ViewGroup _viewGroup;
		List<CustomPin> _pins;

		public CustomInfoWindow (Context context, ViewGroup viewGroup, List<CustomPin> pins)
		{
			_context = context;
			_viewGroup = viewGroup;
			_pins = pins;

		}

		#region IInfoWindowAdapter implementation

		public View GetInfoContents(Marker p0)
		{
			throw new NotImplementedException ();
		}

		public View GetInfoWindow(Marker p0)
		{
			string identifier = GetIdentifier (p0);

			//These would be the markers you want special views for
			switch (identifier) {
			case "Xamarin":
				return (_context as Activity).LayoutInflater.Inflate (Resource.Layout.XamarinPinView, _viewGroup, false);
			case "Train":
				return (_context as Activity).LayoutInflater.Inflate (Resource.Layout.TrainPinView, _viewGroup, false);
			}

			//This would be the default view that you want to set
			var view = new Android.Views.View (_context);

			return view;
		}

		#endregion

		string GetIdentifier(Marker annotation)
		{
			Position annotationPosition = new Position (annotation.Position.Latitude, annotation.Position.Longitude);
			foreach (var pin in _pins) {
				if (pin.FormsPin.Position == annotationPosition)
					return pin.Identifier;	
			}
			return "";
		}
	}
}