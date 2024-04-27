using Programming_2_Project__Calculator_.MathCalc.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_.MathCalc
{
    internal interface IOperation
    {
        double CalculateResult(params double[] numbers);
    }
}
