using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class Factorial : ISingleValueOperation
    {
        public double CalculateResult(params double[] number)
        {
            double res = 1, i;

            for (i = 2; i <= number[0]; i++)
                res *= i;

            return res;
        }
    }
}