using System;
namespace PhysicsDiagrams
{
    /* This class is used to solve equations for the one remaining variable */
    /* Has an input of a string, solves for the sole variable */
    public class Solver : PhysicsFunctions
    {

        string equation;

        public Solver(string equation)
        {

            this.equation = equation;

        }

        public string solve(string variable) {

            /* Manipulate equation, solving for variable */



            return equation;
        }

        /* Use some kind of reverse PEMDAS? */

    }
}
