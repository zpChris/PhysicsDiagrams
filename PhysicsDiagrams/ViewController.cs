using System;
using CoreGraphics;

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

            var fma = new EquationItem("FMA", "Newton's Second Law of Motion", "Fnet = ma");
            fma.Bounds = new CGRect(50, 200, fma.Bounds.Width, fma.Bounds.Height);
            View.AddSubview(fma);

            var spring = new EquationItem("FKX", "Hooke's Law", "Fspring = -kx");
            View.AddSubview(spring);

            var vel = new EquationItem("VFV0AT", "Final Velocity", "vf = v0 + at");
            View.AddSubview(vel);


            var solver = new ApproximationSolver();
            double[] input = { 50, 25, -1 }; // 50 = 25a -> a = 2
            Console.WriteLine(solver.Solve(input, 2));

            input = new double[] { -1, 15, -1.5 }; // F = 15 * -1.5 -> F = -22.5
            Console.WriteLine(solver.Solve(input, 0));

            input = new double[] { 1422342.4, -1, 44332.6642 }; // 1422342.4 = m * 44332.6642 -> m = 32.08
            Console.WriteLine(solver.Solve(input, 1));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
