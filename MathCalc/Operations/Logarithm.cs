using System;

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class Logarithm : ISingleValueOperation
    {
        public double CalculateResult(params double[] number)
        {
            return Math.Log10(number[0]);
        }
    }
}
