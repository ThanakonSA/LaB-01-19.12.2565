using System.Globalization;

namespace LaB_01_19._12._2565
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number1 = this.num1.Text;
            string number2 = this.num2.Text;

            double dNumber1 = 0.0;
            double dNumber2 = 0.0;
            //Convert string to double
            dNumber1 = Double.Parse(number1);
            dNumber2 = Double.Parse(number2);
            //Convert double to string for display
            double result = (dNumber1 + dNumber2);
            this.answer.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = this.num1.Text;
            string number2 = this.num2.Text;

            double dNumber1 = 0.0;
            double dNumber2 = 0.0;
            //Convert string to double
            dNumber1 = Double.Parse(number1);
            dNumber2 = Double.Parse(number2);
            //Convert double to string for display
            double result = (dNumber1 - dNumber2);
            this.answer.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number1 = this.num1.Text;
            string number2 = this.num2.Text;

            double dNumber1 = 0.0;
            double dNumber2 = 0.0;
            //Convert string to double
            dNumber1 = Double.Parse(number1);
            dNumber2 = Double.Parse(number2);
            //Convert double to string for display
            double result = (dNumber1 * dNumber2);
            this.answer.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number1 = this.num1.Text;
            string number2 = this.num2.Text;

            double dNumber1 = 0.0;
            double dNumber2 = 0.0;
            //Convert string to double
            dNumber1 = Double.Parse(number1);
            dNumber2 = Double.Parse(number2);
            //Convert double to string for display
            double result = (dNumber1 / dNumber2);
            this.answer.Text = result.ToString();
        }

        //------------------------------------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
            //เลข 1
            this.SU1.Text = this.SU1.Text + "1";
            this.SU2.Text = this.SU2.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //เลข 2
            this.SU1.Text = this.SU1.Text + "2";
            this.SU2.Text = this.SU2.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //เลข 3
            this.SU1.Text = this.SU1.Text + "3";
            this.SU2.Text = this.SU2.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //เลข 4
            this.SU1.Text = this.SU1.Text + "4";
            this.SU2.Text = this.SU2.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //เลข 5
            this.SU1.Text = this.SU1.Text + "5";
            this.SU2.Text = this.SU2.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //เลข 6
            this.SU1.Text = this.SU1.Text + "6";
            this.SU2.Text = this.SU2.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //เลข 7
            this.SU1.Text = this.SU1.Text + "7";
            this.SU2.Text = this.SU2.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //เลข 8
            this.SU1.Text = this.SU1.Text + "8";
            this.SU2.Text = this.SU2.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //เลข 9
            this.SU1.Text = this.SU1.Text + "9";
            this.SU2.Text = this.SU2.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //เลข 0
            this.SU1.Text = this.SU1.Text + "0";
            this.SU2.Text = this.SU2.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //ปุ่ม +
            input1 = double.Parse(this.SU1.Text);
            operation = "+";
            this.SU1.Text = "";
            this.SU2.Text = this.SU2.Text + "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //ปุ่ม =
            double input2 = double.Parse(this.SU1.Text);
            double result = 0;

            if (this.operation == "+")
            {
                result = input1 + input2;
            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
            }
            else if (this.operation == "*")
            {
                result = input1 * input2;
            }
            else if (this.operation == "/")
            {
                result = input1 / input2;
            }
            this.SU1.Text = result.ToString("#,##0");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.SU1.Text);
            operation = "-";
            this.SU1.Text = "";
            this.SU2.Text = this.SU2.Text + "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.SU1.Text);
            operation = "*";
            this.SU1.Text = "";
            this.SU2.Text = this.SU2.Text + "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.SU1.Text);
            operation = "/";
            this.SU1.Text = "";
            this.SU2.Text = this.SU2.Text + "/";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.SU1.Text = this.SU1.Text + ".";
            this.SU2.Text = this.SU2.Text + ".";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //C
            this.SU1.Text = "";
            this.SU2.Text = "";
        }

        private void SU1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SU2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}