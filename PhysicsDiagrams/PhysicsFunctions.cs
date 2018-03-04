using System;
using System.Collections.Generic;

namespace PhysicsDiagrams
{
    public class PhysicsFunctions
    {
        Func<double[], double> equation;
        EquationItem item;

        static List<string> keys = new List<string>(new string[] { "FMA", "PMV"});

        public PhysicsFunctions(Func<double[], double> equation, EquationItem item)
        {
            this.equation = equation;
            this.item = item;
        }

        public static PhysicsFunctions GetFunction(string key)
        {
            switch (key)
            {
                case "FMA":
                    return new PhysicsFunctions(input => input[1] * input[2] - input[0],
                        new EquationItem(key, "Newton's Second Law", "f=ma"));
                case "PMV":
                    return new PhysicsFunctions(input => input[1] * input[2] - input[0],
                        new EquationItem(key, "Linear Momentum", "p=mv"));
                default:
                    return null;
            }
        }
    }
}
