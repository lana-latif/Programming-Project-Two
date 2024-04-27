using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_2_Project__Calculator_
{
    internal class OperationNameAndTypeAndOrder
    {
        public string Name { get; set; }
        public OperationType Type { get; set; }
        public OperationEnumOrder Order { get; set; }

        public OperationNameAndTypeAndOrder() { }
        public OperationNameAndTypeAndOrder(string name, OperationType type, OperationEnumOrder order)
        {
            Name = name;
            Type = type;
            Order = order;
        }
    }

    internal enum OperationType
    {
        Ln,
        Log,
        InverseNumber,
        Sin,
        Cos,
        Tan,
        MultiplyByNegativeOne,
        Percentage,
        Mod,
        Add,
        Subtract,
        Multiply,
        Divide,
        Factorial,
        PowerTenX,
        PowerXY,
        SQRT
    }

    internal enum OperationEnumOrder
    {
        High = 3, Medium = 2, Low = 1
    }
}
