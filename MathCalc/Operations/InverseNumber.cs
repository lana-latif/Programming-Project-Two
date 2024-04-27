

namespace Programming_2_Project__Calculator_.MathCalc.Operations
{
    internal class InverseNumber : ISingleValueOperation
    {
        public double CalculateResult(params double[] number)
        {
            return 1 / number[0];
        }
    }
}
