# Xamarin.Forms.Maps Custom Popup
## Pictures and videos coming soon

This project displays how to create custom popup views for your pin clicks. Below are explanations for the iOS and Android platforms:

* PCL
    * Utilizes a Custom Map to add a CustomPin property 
    * A Custom Pin allows us to create a Identifier for the Xamarin.Forms.Maps.Pin
    * The Idenentifier will be used for re-use, but the basic implementation in this sample shows how you can customize for multiple pin types.
* Android
    * Utilize IInfoWindowAdapter and IOnMapReadyCallback
    * IOnMapReadyCalback interface gives us access the GoogleMap
    * InfoWindowAdapter allows us to easily access the native view of [**InfoWindow**](http://developer.xamarin.com/guides/android/platform_features/maps_and_location/maps/part_2_-_maps_api/#Info_Windows)
    * InfoWindowAdapter is set on the GoogleMap in the OnMapReady override provided by IOnMapReadyCallback interface implementation.
        * Calling **((Mapview)Control).GetMapAsync(this);** in the custom renderer will trigger **OnMapReady**
    * You would need to set a [OnClickListener](http://developer.android.com/reference/android/view/View.OnClickListener.html) to catch click events of your custom view
*  iOS
    *  Utilizes [MKMapView, MKMapViewDelegate, MKPinAnnotationView and MKAnnotation](http://developer.xamarin.com/guides/ios/platform_features/ios_maps/). *seems compilcated right?*
    * A custom MKMapViewDelegate is set on the MKMapView in the Xamarin.Forms.Maps.iOS.MapRenderer
    * By using a custom MKPinAnnotationView, we can access touch events of our custom view.

##Author
Michael Watson  
Customer Success Engineer  
Xamarin.Forms and Xamarin.Android Specialist
