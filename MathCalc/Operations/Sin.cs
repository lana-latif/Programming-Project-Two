using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class Sin : ISingleValueOperation
    {
        public double CalculateResult(params double[] number)
        {
            return Math.Sin(number[0]);
        }
    }
}
