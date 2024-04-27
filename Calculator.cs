using Programming_2_Project__Calculator_.MathCalc;
using Programming_2_Project__Calculator_.MathCalc.Operations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_2_Project__Calculator_
{
    internal class Calculator
    {
        public Stack<OperationCalc> Operations { get; set; }

        public int ParenthesisCount { get; set; } = 0;

        public bool IsOperationPressed { get; set; }

        public bool IsDotPressed { get; set; }

        public bool IsEorPIPressed { get; set; }

        public bool IsSingleValueOperationPressed { get; set; }

        public bool IsNowParenthesisClosed { get; set; }

        public bool IsTwoValueOperationPressed { get; set; }

        public string LastOperationString { get; set; } = "";

        private Dictionary<OperationType, IOperation> operationMap
            = new Dictionary<OperationType, IOperation>();

        public readonly List<OperationNameAndTypeAndOrder> SingleOperatorList = new List<OperationNameAndTypeAndOrder>()
        {
            new OperationNameAndTypeAndOrder("LnButton", OperationType.Ln, OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("MultiplyByNegativeOneButton", OperationType.MultiplyByNegativeOne, OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("LogButton", OperationType.Log, OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("TenPowerXButton", OperationType.PowerTenX , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("SQRTButton", OperationType.SQRT , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("FactorialButton", OperationType.Factorial , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("InverseNumberButton", OperationType.InverseNumber , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("PercentageButton", OperationType.Percentage , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("TanButton", OperationType.Tan , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("CosButton", OperationType.Cos , OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("SinButton", OperationType.Sin , OperationEnumOrder.High),
        };

        public readonly List<OperationNameAndTypeAndOrder> TwoOperatorList = new List<OperationNameAndTypeAndOrder>()
        {
            new OperationNameAndTypeAndOrder("XPoweYButton", OperationType.PowerXY, OperationEnumOrder.High),
            new OperationNameAndTypeAndOrder("ModButton", OperationType.Mod, OperationEnumOrder.Medium),
            new OperationNameAndTypeAndOrder("DivideButton", OperationType.Divide, OperationEnumOrder.Medium),
            new OperationNameAndTypeAndOrder("MultiplyButton", OperationType.Multiply, OperationEnumOrder.Medium),
            new OperationNameAndTypeAndOrder("MinusButton", OperationType.Subtract, OperationEnumOrder.Low),
            new OperationNameAndTypeAndOrder("PlusButton", OperationType.Add, OperationEnumOrder.Low),
        };

        public Calculator()
        {
            Operations = new Stack<OperationCalc>();
            Operations.Push(new OperationCalc());

            operationMap.Add(OperationType.Ln, new NaturalLogarithm());
            operationMap.Add(OperationType.Log, new Logarithm());
            operationMap.Add(OperationType.Sin, new Sin());
            operationMap.Add(OperationType.Cos, new Cos());
            operationMap.Add(OperationType.Tan, new Tan());
            operationMap.Add(OperationType.InverseNumber, new InverseNumber());
            operationMap.Add(OperationType.MultiplyByNegativeOne, new MultiplyByNegativeOne());
            operationMap.Add(OperationType.Factorial, new Factorial());
            operationMap.Add(OperationType.Percentage, new Percentage());
            operationMap.Add(OperationType.PowerTenX, new Power(10));
            operationMap.Add(OperationType.SQRT, new Sqrt());
            operationMap.Add(OperationType.Mod, new Mod());
            operationMap.Add(OperationType.PowerXY, new Power());
            operationMap.Add(OperationType.Add, new Addition());
            operationMap.Add(OperationType.Subtract, new Subtraction());
            operationMap.Add(OperationType.Multiply, new Multiplication());
            operationMap.Add(OperationType.Divide, new Division());
        }

        public double MakeCalculation(double[] operands, OperationType? operationType)
        {
            IOperation operationMapValue = operationMap.First(x => x.Key == operationType).Value;
            return operationMapValue.CalculateResult(operands);
        }


        public void ClearAll()
        {
            Operations = new Stack<OperationCalc>();
            Operations.Push(new OperationCalc());
            IsOperationPressed = false;
            IsDotPressed = false;
            IsEorPIPressed = false;
            IsSingleValueOperationPressed = false;
            IsTwoValueOperationPressed = false;
            IsNowParenthesisClosed = false;
            LastOperationString = "";
        }


        public double MakeSingleValueCalculation(double[] operands, OperationType? operationType)
        {
            var operationCalc = Operations.Peek();
            var lastOperationIndex = operationCalc.Values.Count - 1;
            var result = MakeCalculation(operands, operationType);
            if (string.IsNullOrEmpty(operationCalc.Values[lastOperationIndex].FirstNumber) && operationCalc.Values[lastOperationIndex].Previous == null || operationCalc.Values[lastOperationIndex].OperationType == null)
            {
                operationCalc.Values[lastOperationIndex].FirstNumber = result.ToString();
            }
            else
            {
                operationCalc.Values[lastOperationIndex].SecondNumber = result.ToString();
            }
            return result;
        }

        public void AddOperation(double? number, OperationType type)
        {
            var operationCalc = Operations.Peek();
            var lastOperation = operationCalc.Values[operationCalc.Values.Count - 1];
            if (string.IsNullOrEmpty(lastOperation.FirstNumber) && lastOperation.Previous == null)
            {
                if (number != null)
                    lastOperation.FirstNumber = number.ToString();
                lastOperation.OperationType = type;
            }
            else if (string.IsNullOrEmpty(lastOperation.SecondNumber))
            {
                if (lastOperation.OperationType == null)
                {
                    lastOperation.OperationType = type;
                    return;
                }
                else
                {
                    operationCalc.Values.Add(new SingleOperationCalc()
                    {
                        Previous = lastOperation,
                        OperationType = type
                    });
                }
                if (number != null)
                    lastOperation.SecondNumber = number.ToString();
            }
            else
            {
                if (IsSingleValueOperationPressed) operationCalc.Values.Add(new SingleOperationCalc()
                {
                    Previous = lastOperation,
                    OperationType = type,
                }
                );
                else operationCalc.Values.Add(new SingleOperationCalc()
                {
                    Previous = lastOperation,
                    OperationType = type,
                    SecondNumber = number.ToString()
                }
                );
            }
        }

        public bool CheckIfCanCalc()
        {
            var operationCalc = Operations.Peek();
            if (operationCalc.Values.Count > 1)
            {
                for (int i = 0; i < operationCalc.Values.Count - 1; i++)
                {
                    if (GetOperationOrder(operationCalc.Values[i].OperationType) >= GetOperationOrder(operationCalc.Values[i + 1].OperationType))
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public OperationEnumOrder GetOperationOrder(OperationType? type)
        {
            var data = TwoOperatorList.Find(x => x.Type == type);
            return data != null ? data.Order : SingleOperatorList.Find(x => x.Type == type).Order;
        }

        public string DoCalc()
        {
            double value = 0.0;
            bool isCalc = false;
            if (CheckIfCanCalc())
            {
                var operationCalc = Operations.Peek();
                for (int i = 0; i < operationCalc.Values.Count - 1; i++)
                {
                    if (GetOperationOrder(operationCalc.Values[i].OperationType) >=
                    GetOperationOrder(operationCalc.Values[i + 1].OperationType))
                    {
                        isCalc = true;
                        double firstNumberVal;
                        if (operationCalc.Values[i].Previous != null)
                        {
                            firstNumberVal = Convert.ToDouble(operationCalc.Values[i].Previous.SecondNumber);
                        }
                        else
                        {
                            firstNumberVal = Convert.ToDouble(operationCalc.Values[i].FirstNumber);
                        }
                        value = MakeCalculation(new double[]
                        {
                                        firstNumberVal,
                                        Convert.ToDouble(operationCalc.Values[i].SecondNumber)
                        },
                        operationCalc.Values[i].OperationType
                        );
                        if (operationCalc.Values[i].Previous != null)
                        {
                            operationCalc.Values[i].Previous.SecondNumber = value.ToString();
                            if (i + 1 < operationCalc.Values.Count)
                            {
                                operationCalc.Values[i + 1].Previous = operationCalc.Values[i - 1];
                            }
                            operationCalc.Values.RemoveAt(i);
                        }
                        else
                        {
                            operationCalc.Values[i + 1].FirstNumber = value.ToString();
                            operationCalc.Values[i + 1].Previous = null;
                            operationCalc.Values.RemoveAt(i);
                        }
                        i = -1;
                    }
                }
            }
            return isCalc ? value.ToString() : null;
        }

        public string DoFullCalc()
        {
            double value = 0.0;
            bool isCalc = false;
            var operationCalc = Operations.Peek();
            for (int i = 0; i < operationCalc.Values.Count; i++)
            {
                isCalc = true;
                var checkValue = OperationEnumOrder.Low;
                if (i + 1 != operationCalc.Values.Count)
                    checkValue = GetOperationOrder(operationCalc.Values[i + 1].OperationType);
                if (GetOperationOrder(operationCalc.Values[i].OperationType) >= checkValue)
                {
                    double firstNumberVal;
                    if (operationCalc.Values[i].Previous != null)
                    {
                        firstNumberVal = Convert.ToDouble(operationCalc.Values[i].Previous.SecondNumber);
                    }
                    else
                    {
                        firstNumberVal = Convert.ToDouble(operationCalc.Values[i].FirstNumber);
                    }
                    value = MakeCalculation(new double[]
                    {
                                        firstNumberVal,
                                        Convert.ToDouble(operationCalc.Values[i].SecondNumber)
                    },
                    operationCalc.Values[i].OperationType
                    );
                    if (operationCalc.Values[i].Previous != null)
                    {
                        operationCalc.Values[i].Previous.SecondNumber = value.ToString();
                        if (i + 1 < operationCalc.Values.Count)
                        {
                            operationCalc.Values[i + 1].Previous = operationCalc.Values[i - 1];
                        }
                        operationCalc.Values.RemoveAt(i);
                    }
                    else
                    {
                        if (i + 1 < operationCalc.Values.Count)
                        {
                            operationCalc.Values[i + 1].FirstNumber = value.ToString();
                            operationCalc.Values[i + 1].Previous = null;
                        }
                        operationCalc.Values.RemoveAt(i);
                    }
                    i = -1;
                }
            }
            Operations.Pop();
            if (Operations.Count == 0)
            {
                Operations.Push(new OperationCalc());
            }
            if (!isCalc)
                return null;
            else
            {
                operationCalc = Operations.Peek();
                var lastOperationIndex = operationCalc.Values.Count - 1;
                if (string.IsNullOrEmpty(operationCalc.Values[lastOperationIndex].FirstNumber) && operationCalc.Values[lastOperationIndex].Previous == null || operationCalc.Values[lastOperationIndex].OperationType == null)
                {
                    operationCalc.Values[lastOperationIndex].FirstNumber = value.ToString();
                }
                else
                {
                    operationCalc.Values[lastOperationIndex].SecondNumber = value.ToString();
                }
            }
            return value.ToString();
        }
    }
}