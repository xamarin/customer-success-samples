Tinderesq Swipe
=====
Create a draggable view that is similar to Tinder's in Xamarin.iOS.
## Installation
1. Copy the DraggableView folder to your project.
2. Code away.

## Screenshots
![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/TinderesqSwipe/TinderesqSwipe/Screenshots/SwipeLeft.png "Xamarin.iOS, Swipe Left")
![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/TinderesqSwipe/TinderesqSwipe/Screenshots/Middle.png"Xamarin.iOS, Middle")
![screenshot](https://github.com/xamarin/customer-success/blob/master/samples/Xamarin.iOS/TinderesqSwipe/TinderesqSwipe/Screenshots/SwipeRight.png "Xamarin.iOS, Swipe Right")
## Example

#####Create a DraggableImageView and add a view:
``` 
var draggableImageView = new DraggableImageView (UIImage.FromFile ("profilepic.jpg"), new CGRect (5, 20, 300, 354));
``` 
#####Wire up the swipe event:
``` 
DraggableImageView.OnSwipe += HandleOnSwipe;
``` 
#####Handle the swipe event:

```
private void HandleOnSwipe (object sender, DraggableEventArgs evt)
{
	if (!evt.Dragged.Equals (DraggableDirection.None)) {
		var message = evt.Dragged.Equals (DraggableDirection.Left) ? "You Chose Poorly" : "You Swiped Right";
		new UIAlertView ("Swiped", message, null, "OK", "OK").Show ();
	}
}
```
Xamarin.iOS Version
---------------------
This sample was written with [Xamarin.iOS 8.0](http://xamarin.com/platform)

Authors
-------
Jon Davis
