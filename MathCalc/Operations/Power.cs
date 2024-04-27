using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class Power : ITwoValueOperation
    {

        private double? _left;
        public Power() { }
        public Power(double left)
        {
            _left = left;
        }
        public double CalculateResult(params double[] number)
        {
            if (_left != null)
            {
                return Math.Pow((double)_left, number[0]);

            }
            return Math.Pow(number[0], number[1]);
        }
    }
}
