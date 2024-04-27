using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace Programming_2_Project__Calculator_
{
    public partial class CalculatorForm : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private bool isEqual;

        readonly Calculator calculator;

        public CalculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();
        }


        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = MainPanel;
            MultiplyByNegativeOneButton.Text = "\u00B1";
            TenPowerXButton.Text = "10" + "\u02E3";
            XPoweYButton.Text = "x" + "\u02B8";
            SQRTButton.Text = "\u221A";
            PiButton.Text = "\u03C0";
            DeleteButton.Text = "\u232B";
            PercentageButton.Text = "\u0025";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HistoryLabel_TextChanged(object sender, EventArgs e)
        {
            ToolTipHistory.SetToolTip(HistoryLabel, HistoryLabel.Text);
        }

        private void NumberClick(object sender, EventArgs e)
        {
            if (MainTextBox.Text.Contains("∞") || MainTextBox.Text.Contains("Invalid Operation"))
            {
                ClearButton.PerformClick();
            }
            ClearMainTextBox();
            calculator.IsOperationPressed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!calculator.IsDotPressed || !MainTextBox.Text.Contains("."))
                {
                    if (MainTextBox.Text.Length == 0)
                    {
                        MainTextBox.Text = "0";
                    }
                    MainTextBox.Text += button.Text;
                    calculator.IsDotPressed = true;
                }
            }
            else
                MainTextBox.Text += button.Text;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ClearMainTextBox();
            int index = MainTextBox.Text.Length;
            if (index > 0)
            {
                index--;
                MainTextBox.Text = MainTextBox.Text.Remove(index);
                if (MainTextBox.Text == "")
                {
                    MainTextBox.Text = "0";
                }
            }
            else
            {
                MainTextBox.Text = "0";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (MainTextBox.Text != "0" && !MainTextBox.Text.Contains("∞")
                && !MainTextBox.Text.Contains("Invalid Operation") && !isEqual)
            {
                MainTextBox.Text = "0";
            }
            else
            {
                MainTextBox.Text = "0";
                calculator.ClearAll();
                HistoryLabel.Text = "";
                isEqual = false;
            }
        }
        private void PiButton_Click(object sender, EventArgs e)
        {
            calculator.IsEorPIPressed = true;
            MainTextBox.Text = Math.PI.ToString();
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            calculator.IsEorPIPressed = true;
            MainTextBox.Text = Math.E.ToString();
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            if (MainTextBox.Text.Contains("∞") || MainTextBox.Text.Contains("Invalid Operation") || isEqual)
            {
                ClearButton.PerformClick();
            }
            Button button = sender as Button;
            (bool isSingle, OperationNameAndTypeAndOrder fullOperationData) = IsSingleValueOperator(button.Name);
            string numberString = MainTextBox.Text.Trim();
            calculator.IsOperationPressed = !isSingle;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    double number = Convert.ToDouble(numberString);
                    double temp = 0;
                    if (isSingle)
                    {
                        temp = calculator.MakeSingleValueCalculation(new double[] { number }, fullOperationData.Type);
                        if (temp.Equals(double.NaN))
                        {
                            throw new Exception();
                        }
                        calculator.IsSingleValueOperationPressed = true;
                        this.BeginInvoke(new Action(() =>
                        {
                            if (calculator.IsTwoValueOperationPressed)
                            {
                                if (calculator.LastOperationString.Length != 0)
                                {
                                    HistoryLabel.Text = HistoryLabel.Text.Replace(calculator.LastOperationString, "");
                                }
                                string lastOperation = GetOperationAsString(fullOperationData.Type, string.IsNullOrEmpty(calculator.LastOperationString) ? MainTextBox.Text : calculator.LastOperationString);
                                HistoryLabel.Text += lastOperation;
                                calculator.LastOperationString = lastOperation;
                            }
                            else
                                HistoryLabel.Text = GetOperationAsString(fullOperationData.Type, string.IsNullOrEmpty(HistoryLabel.Text) ? MainTextBox.Text : HistoryLabel.Text);

                            MainTextBox.Text = temp.ToString();
                        }));
                    }
                    else
                    {
                        calculator.IsTwoValueOperationPressed = true;
                        this.BeginInvoke(new Action(() =>
                        {
                            if (string.IsNullOrEmpty(HistoryLabel.Text))
                                HistoryLabel.Text = GetOperationAsString(fullOperationData.Type, MainTextBox.Text);
                            else
                            {
                                if (calculator.IsSingleValueOperationPressed || calculator.IsNowParenthesisClosed)
                                {
                                    HistoryLabel.Text += GetOperationAsString(fullOperationData.Type, "");
                                }
                                else
                                {
                                    HistoryLabel.Text += GetOperationAsString(fullOperationData.Type, MainTextBox.Text);
                                }
                            }
                            calculator.IsSingleValueOperationPressed = false;
                            calculator.IsNowParenthesisClosed = false;
                            calculator.LastOperationString = "";
                        }));
                        if (calculator.IsNowParenthesisClosed)
                            calculator.AddOperation(null, fullOperationData.Type);
                        else
                            calculator.AddOperation(number, fullOperationData.Type);
                        string value = calculator.DoCalc();
                        if (value != null)
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                MainTextBox.Text = value;
                            }));
                        }
                    }
                }
                catch (Exception)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        MainTextBox.Text = "Invalid Operation";
                    }));
                }

            });
        }

        private void OpenParenthesisButton_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                MainTextBox.Text = "0";
                calculator.ClearAll();
                HistoryLabel.Text = "";
                isEqual=false;
            }
            calculator.ParenthesisCount++;
            if (calculator.Operations.Peek().Values[0].FirstNumber != null)
                calculator.Operations.Push(new OperationCalc());
            this.BeginInvoke(new Action(() =>
            {
                if (string.IsNullOrEmpty(HistoryLabel.Text))
                    HistoryLabel.Text = "( ";
                else
                {
                    if (calculator.IsSingleValueOperationPressed)
                    {
                        HistoryLabel.Text += " x ( ";
                    }
                    else
                    {
                        HistoryLabel.Text += " ( ";
                    }
                }
                calculator.IsSingleValueOperationPressed = false;
                calculator.IsTwoValueOperationPressed = false;
                calculator.LastOperationString = "";
            }));
        }

        private void CloseParenthesisButton_Click(object sender, EventArgs e)
        {
            if (calculator.ParenthesisCount != 0)
            {
                calculator.ParenthesisCount--;
                if (calculator.IsTwoValueOperationPressed)
                {
                    var operationCalc = calculator.Operations.Peek();
                    var lastOperationIndex = operationCalc.Values.Count - 1;
                    if (string.IsNullOrEmpty(operationCalc.Values[lastOperationIndex].FirstNumber) && operationCalc.Values[lastOperationIndex].Previous == null || operationCalc.Values[lastOperationIndex].OperationType == null)
                    {
                        operationCalc.Values[lastOperationIndex].FirstNumber = MainTextBox.Text;
                    }
                    else
                    {
                        operationCalc.Values[lastOperationIndex].SecondNumber = MainTextBox.Text;
                    }
                }
                string value = calculator.DoFullCalc();
                if (value != null)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        MainTextBox.Text = value;
                        value = calculator.DoCalc();
                        if (value != null)
                        {
                            MainTextBox.Text = value;
                        }
                    }));
                }
                HistoryLabel.Text += calculator.IsNowParenthesisClosed? ")" : (calculator.IsSingleValueOperationPressed ? "" : MainTextBox.Text) + " ) ";
                calculator.IsSingleValueOperationPressed = false;
                calculator.IsTwoValueOperationPressed = false;
                calculator.IsNowParenthesisClosed = true;
                calculator.LastOperationString = "";
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            var temp = MainTextBox.Text;
            if (calculator.IsTwoValueOperationPressed)
            {
                var operationCalc = calculator.Operations.Peek();
                var lastOperationIndex = operationCalc.Values.Count - 1;
                if (string.IsNullOrEmpty(operationCalc.Values[lastOperationIndex].FirstNumber) && operationCalc.Values[lastOperationIndex].Previous == null || operationCalc.Values[lastOperationIndex].OperationType == null)
                {
                    operationCalc.Values[lastOperationIndex].FirstNumber = temp ;
                }
                else
                {
                    operationCalc.Values[lastOperationIndex].SecondNumber = temp;
                }
            }
            int count = calculator.Operations.Count;
            string value = "";
            for (int i = 0; i < count; i++)
            {
                value = calculator.DoFullCalc();
            }
            isEqual = true;
            MainTextBox.Text = value;
            HistoryLabel.Text += (calculator.IsSingleValueOperationPressed ? "" : temp) + " = ";
        }

        private (bool, OperationNameAndTypeAndOrder) IsSingleValueOperator(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new Exception("Invalid Operation");
            OperationNameAndTypeAndOrder operation = calculator.SingleOperatorList.Find(x => x.Name.Equals(name));
            if (operation != null)
            {
                return (true, operation);
            }
            else
            {
                operation = calculator.TwoOperatorList.Find(x => x.Name.Equals(name));
                return (false, operation);
            }
        }
        private void ClearMainTextBox()
        {
            if (calculator.IsSingleValueOperationPressed && !calculator.IsTwoValueOperationPressed || isEqual)
            {
                calculator.ClearAll();
                HistoryLabel.Text = "";
                MainTextBox.Text = "";
                isEqual = false;
            }
            else if (
                MainTextBox.Text == "0"
                || calculator.IsOperationPressed
                || calculator.IsEorPIPressed
                || MainTextBox.Text.Contains("∞")
                || MainTextBox.Text.Contains("Invalid Operation")
                )
            {
                MainTextBox.Clear();
                calculator.IsDotPressed = false;
                calculator.IsEorPIPressed = false;
            }
        }

        private string GetOperationAsString(OperationType operationType, params string[] numbers)
        {
            if (numbers.Length < 2)
            {
                string number1 = numbers[0];
                numbers = new string[2] {
                    number1, ""
                };
            }
            switch (operationType)
            {
                case OperationType.Ln:
                    return "ln(" + numbers[0] + ")";
                case OperationType.Log:
                    return "log(" + numbers[0] + ")";
                case OperationType.SQRT:
                    return "\u221A" + numbers[0];
                case OperationType.Mod:
                    return numbers[0] + " mod " + numbers[1];
                case OperationType.InverseNumber:
                    return "1/" + numbers[0];
                case OperationType.MultiplyByNegativeOne:
                    return numbers[0] + " x -1";
                case OperationType.Sin:
                    return "sin(" + numbers[0] + ")";
                case OperationType.Cos:
                    return "cos(" + numbers[0] + ")";
                case OperationType.Tan:
                    return "tan(" + numbers[0] + ")";
                case OperationType.Factorial:
                    return numbers[0] + "!";
                case OperationType.Add:
                    return numbers[0] + " + " + numbers[1];
                case OperationType.Multiply:
                    return numbers[0] + " x " + numbers[1];
                case OperationType.Divide:
                    return numbers[0] + " ÷ " + numbers[1];
                case OperationType.Subtract:
                    return numbers[0] + " - " + numbers[1];
                case OperationType.PowerTenX:
                    return "10" + " ^ " + numbers[0];
                case OperationType.PowerXY:
                    return numbers[0] + " ^ " + numbers[1];
                case OperationType.Percentage:
                    return numbers[0] + "/100";
                default:
                    return "";
            }
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    OneButton.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    TwoButton.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    ThreeButton.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    FourButton.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    FiveButton.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    SixButton.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    SevenButton.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    EightButton.PerformClick();
                    break;
                case Keys.Multiply:
                    MultiplyButton.PerformClick();
                    break;
                case Keys.Divide:
                    DivideButton.PerformClick();
                    break;
                case Keys.Enter:
                    EqualButton.PerformClick();
                    break;
                case Keys.Back:
                    DeleteButton.PerformClick();
                    break;
                case Keys.Delete:
                    ClearButton.PerformClick();
                    break;
            }
        }

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    ZeroButton.PerformClick();
                    break;
                case '9':
                    NineButton.PerformClick();
                    break;
                case '+':
                    PlusButton.PerformClick();
                    break;
                case '-':
                    MinusButton.PerformClick();
                    break;
                case '=':
                    EqualButton.PerformClick();
                    break;
                case '.':
                    DotButton.PerformClick();
                    break;
                case ')':
                    CloseParenthesisButton.PerformClick();
                    break;
                case '(':
                    OpenParenthesisButton.PerformClick();
                    break;
            }
        }
    }
}