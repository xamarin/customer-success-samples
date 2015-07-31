using System;
using Xamarin.Forms.Maps;
using System.Collections.Generic;

namespace FormsMapClickPopUp
{
	public class CustomMap : Map
	{
		public List<CustomPin> CustomPins { get; set; }
	}
}