using System;

class ApproximationSolver
{

    public const double Accuracy = 0.01;

    /**
     * Takes double array of values and an int index which represents the
     * index in the array contains the missing value. Starts by finding a
     * a value for the unknown variable that causes the equation to be 
     * greater than 0 and another that's less than 0. Then continuously 
     * calculates the value at the midpoint between the two until the value 
     * converges to 0. 
     *
     */
    public double Solve(double[] input, int index)
    {
        // Along with discontinuous functions issue, another problem is what 
        // if the negative values only appear in the interval like [100, 101], 
        // so doing *= -2 skips past that and it's never found

        double bigIndex = 1;
        double smallIndex = 1;

        // Sets bigIndex and smallIndex to pos. and neg. values
        input[index] = bigIndex;
        while (equation(input) < 0)
        {
            bigIndex *= -2;
            input[index] = bigIndex;
        }

        input[index] = smallIndex;
        while (equation(input) > 0)
        {
            smallIndex *= -2;
            input[index] = smallIndex;
        }

        // Finds midpoint values between smallIndex and bigIndex for the unknown 
        // variable until it results in the equation returning 0 (within accuracy). 
        double midIndex = (smallIndex + bigIndex) / 2;
        input[index] = midIndex;
        double midSum = equation(input);

        while (Math.Abs(midSum) > Accuracy)
        {
            if (midSum > 0) {
                bigIndex = midIndex;
            }
            else
            {
                smallIndex = midIndex;
            }
            midIndex = (smallIndex + bigIndex) / 2;
            input[index] = midIndex;
            midSum = equation(input);
        }

        return midIndex;
    }

    // I think this method (which we should rename) should be in the FMA class
    // and this class will contain an instance of that FMA class to make the 
    // call fma.equation(input) to. 
    public double equation(double[] input)
    {
        // F = ma | 0 -> F 1 -> m 2 ->a
        return input[1] * input[2] - input[0];
    }
}










