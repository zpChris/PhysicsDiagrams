using System;

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
