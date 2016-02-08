using System;
using Foundation;
using UIKit;

namespace ForceAppliedSample
{
    public partial class ViewController : UIViewController
    {
        public bool ForceTouchEnabled = false;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            LabelForce.Text = $"Force Applied: 0";
            LabelForce.MinimumFontSize = 25;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {            
            base.TraitCollectionDidChange(previousTraitCollection);

            //See if the new TraitCollection value includes force touch
            if (TraitCollection.ForceTouchCapability == UIForceTouchCapability.Available)
            {
                ForceTouchEnabled = true;
            }
            else
            {
                LabelForce.Text = "Force Touch not available";
            }

        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        { 
            base.TouchesMoved(touches, evt);

            if (ForceTouchEnabled)
            {
                UITouch touch = touches.AnyObject as UITouch;

                if (touch != null)
                {
                    var force = touch.Force;
                    var smallForce = Convert.ToUInt32(force);
                    LabelForce.Text = $"Force Applied: {smallForce}";
                    this.View.BackgroundColor = new UIColor(0, 255, 0, force / 7);
                }

            }

        }
    

    }
}