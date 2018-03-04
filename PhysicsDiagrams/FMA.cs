using System;
using System.Collections.Generic;

namespace PhysicsDiagrams
{
    public class FMA : Mechanics
    {

        double force;
        double mass;
        double acceleration;
        string FMAEquation = "[force] = [mass] * [acceleration]";

        public FMA(Dictionary<string, double> values)
        {

            values.TryGetValue("force", out this.force);
            values.TryGetValue("mass", out this.mass);
            values.TryGetValue("acceleration", out this.acceleration);

        }

        public double Solve() {

            Solver solver = new Solver(FMAEquation);
            solver.solve("[mass]"); // This would be if you are solving for mass, normally a var would go here based on current values

            /* Input variables into equation, do the computation IN SOLVER (still have to construct basics) */

            return 1.0; // Placeholder

        }
    }
}
