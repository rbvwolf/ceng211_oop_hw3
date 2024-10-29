namespace Homework3OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sel;
        int num1, num2, result;
        double result1;

        private void b0_Click(object sender, EventArgs e)
        {
            tinput.Text += b0.Text;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            tinput.Text += b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tinput.Text += b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            tinput.Text += b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tinput.Text += b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tinput.Text += b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tinput.Text += b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tinput.Text += b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tinput.Text += b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            tinput.Text += b9.Text;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (tinput.Text.Length > 0)
            {
                tinput.Text = tinput.Text.Substring(0, tinput.Text.Length - 1);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tinput.Clear();
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            sel = "+";
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            sel = "-";
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
        }

        private void bMult_Click(object sender, EventArgs e)
        {
            sel = "*";
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            sel = "/";
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
        }

        private void bFact_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            int factorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorial *= i;
            }
            tinput.Text = factorial.ToString();
        }

        private void bSin_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Sin(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Cos(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bTan_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Tan(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bCot_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = 1 / Math.Tan(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bSec_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = 1 / Math.Cos(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bAsin_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Asin(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bAcos_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Acos(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bAtan_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Atan(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bAcot_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.PI / 2 - Math.Atan(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bCosec_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = 1 / Math.Sin(num1 * Math.PI / 180);
            tinput.Text = result1.ToString();
        }

        private void bSquare_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Pow(num1, 2);
            tinput.Text = result1.ToString();
        }

        private void bEx_Click(object sender, EventArgs e)
        {
            sel = "^x";
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Sqrt((double)num1);
            tinput.Text = result1.ToString();
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Log10((double)num1);
            tinput.Text = result1.ToString();
        }

        private void bLn_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Log((double)num1);
            tinput.Text = result1.ToString();
        }

        private void bAbs_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tinput.Text);
            tinput.Clear();
            result1 = Math.Abs((double)num1);
            tinput.Text = result1.ToString();
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            if (sel == "+")
            {
                num2 = int.Parse(tinput.Text);
                result = num1 + num2;
                tinput.Text = result.ToString();
            }
            if (sel == "-")
            {
                num2 = int.Parse(tinput.Text);
                result = num1 - num2;
                tinput.Text = result.ToString();
            }
            if (sel == "*")
            {
                num2 = int.Parse(tinput.Text);
                result = num1 * num2;
                tinput.Text = result.ToString();
            }
            if (sel == "/")
            {
                num2 = int.Parse(tinput.Text);
                if (num2 != 0)
                {
                    result1 = (double) num1 / num2;
                    tinput.Text = result1.ToString();
                }
                else
                {
                    MessageBox.Show("You cannot divide by 0!", "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (sel == "^x")
            {
                num2 = int.Parse(tinput.Text);
                result1 = Math.Pow(num1, num2);
                tinput.Text = result1.ToString();
            }
        }
    }
}
