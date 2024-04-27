using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class NaturalLogarithm : ISingleValueOperation
    {
        public double CalculateResult(params double[] number)
        {
            return Math.Log(number[0]);
        }
    }
}
