using System;

class ApproximationSolver
{

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
        // Along with discontinuous functions issue, what if the negative
        // values only appear in the interval like [100, 101], so doing
        // *= -2 skips past that and it's never found

        double bigIndex = 1;
        double smallIndex = 1;

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

        double midIndex = (smallIndex + bigIndex) / 2;
        input[index] = midIndex;
        double midSum = equation(input);

        while (Math.Abs(midSum) > 0.01)
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

    public double equation(double[] input)
    {
        // F = ma | 0 -> F 1 -> m 2 ->a
        return input[1] * input[2] - input[0];
    }
}










