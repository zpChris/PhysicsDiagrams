using System;
using System.Collections.Generic;

namespace PhysicsDiagrams
{
    public class FMA : Mechanics
    {

        double[] input;
        bool friction = false;

        // force (0), mass (1), acceleration (2)

        public FMA(double force, double mass, double acceleration, bool friction)
        {

            input = new double[] { force, mass, acceleration };
            this.friction = friction;

        }

        public double GetFMAEquation()
        {

            if (friction)
            {
                return 1.0; // ?
            } else {
                return input[1] * input[2] - input[0];
            }

        }
    }
}
