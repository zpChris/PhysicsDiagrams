using System;
using System.Drawing;

using UIKit;

namespace PhysicsDiagrams
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var fma = new EquationItem(50, 50, "Newton's Second Law of Motion", "Fnet = ma");
            View.AddSubview(fma);

            var spring = new EquationItem(50, 255, "Hooke's Law", "Fspring = -kx");
            View.AddSubview(spring);

            var vel = new EquationItem(50, 460, "Final Velocity", "vf = v0 + at");
            View.AddSubview(vel);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
