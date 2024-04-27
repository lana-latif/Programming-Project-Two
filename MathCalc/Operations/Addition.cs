using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class Addition : ITwoValueOperation
    {
        public double CalculateResult(params double[] number)
        {
            return number[0] + number[1];
        }
    }
}
