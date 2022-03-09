using Calculations;
namespace Session_06
{
    public partial class Form1 : Form
    {
        private double number1;
        private CalculationType? calculationType;
        private bool dotFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType == null)
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += " + ";
                calculationType = CalculationType.Add;
                dotFlag = false;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double number2;
            double answer;
            string displayedString = Convert.ToString(textBox1.Text); 
            

            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType != null && calculationType != CalculationType.SquareRoot)
            {   
                
                var text = textBox1.Text.Split(' ');
                number2 = Convert.ToDouble(text[2]);
                switch (calculationType)
                {
                    case CalculationType.Add:
                        var add = new Addition();
                        answer = add.Add(number1, number2);
                        displayedString = answer.ToString();
                        break;
                    case CalculationType.Subtract:
                        var subtract = new Subtraction();
                        answer = subtract.Sub(number1, number2);
                        displayedString = answer.ToString();
                        break;
                    case CalculationType.Multiply:
                        var multiply = new Multiplication();
                        answer = multiply.Mult(number1, number2);
                        displayedString = answer.ToString();
                        break;
                    case CalculationType.Divide:
                        var divide = new Division();
                        answer = divide.Div(number1, number2);
                        displayedString= answer.ToString();
                        break;
                    case CalculationType.RaiseToPower:
                        var power = new Power();
                        answer = power.Pow(number1, number2);
                        displayedString = answer.ToString();
                        break;
                    default:
                        break;
                }


                textBox1.Text = displayedString;
                calculationType = null;
                dotFlag = false;

            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType == null)
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += " / ";
                calculationType = CalculationType.Divide;
                dotFlag = false;
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType == null)
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += " * ";
                calculationType = CalculationType.Multiply;
                dotFlag = false;
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType == null)
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += " - ";
                calculationType = CalculationType.Subtract;
                dotFlag = false;
            }
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType == null)
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += " ^ ";
                calculationType = CalculationType.RaiseToPower;
                dotFlag = false;
            }
        }

        private void buttonSqrRoot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && calculationType == null || calculationType==CalculationType.SquareRoot)
            {
                number1 = Convert.ToDouble(textBox1.Text);
                var sqrRoot = new SquareRoot();
                double answer = sqrRoot.SqrRoot(number1);
                textBox1.Text = answer.ToString();
                dotFlag = false;
                calculationType = CalculationType.SquareRoot;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!dotFlag && calculationType != CalculationType.SquareRoot)
            {
                dotFlag = true;
                textBox1.Text += ".";
            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            dotFlag = false;
            calculationType = null;
            number1 = 0;
            textBox1.Text = null;
        }
    }
}