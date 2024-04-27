using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_
{
    internal class OperationCalc
    {
        public List<SingleOperationCalc>
            Values
        { get; set; }

        public OperationCalc()
        {
            Values = new List<SingleOperationCalc>()
            {
                new SingleOperationCalc()
            };
        }
    }

    class SingleOperationCalc
    {
        public SingleOperationCalc Previous { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public OperationType? OperationType { get; set; }

    }
}