using System;

using CoreLocation;
using MapKit;

namespace FormsMapClickPopUp.iOS.CustomMap_iOS
{
	public class CustomPinAnnotation : MKAnnotation
	{
		string title, subtitle;
		public override CLLocationCoordinate2D Coordinate { get { return this.Coords; }}
		public CLLocationCoordinate2D Coords;
		public override string Title { get{ return title; }}
		public override string Subtitle { get{ return subtitle; }}
		public CustomPinAnnotation (CLLocationCoordinate2D coordinate, string title, string subtitle) 
		{
			this.Coords = coordinate;
			this.title = title;
			this.subtitle = subtitle;
		}
	}
}