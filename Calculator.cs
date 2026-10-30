
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharif_programs
{
    public partial class Calculator : Form
    {
        float firstvalue, secondvalue;
        string op = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "1";
            else
                txtValue.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "2";
            else
                txtValue.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "3";
            else
                txtValue.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "4";
            else
                txtValue.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "5";
            else
                txtValue.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "6";
            else
                txtValue.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "7";
            else
                txtValue.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "8";
            else
                txtValue.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Text = "9";
            else
                txtValue.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
                txtValue.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            txtDetails.Clear();

            firstvalue = 0;
            secondvalue = 0;
            op = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtValue.Text.Contains("."))
                txtValue.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToSingle(txtValue.Text);
            op = "+";
            txtValue.Text = "0";
            txtDetails.Text = firstvalue + " " + op;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToSingle(txtValue.Text);
            op = "-";
            txtValue.Text = "0";
            txtDetails.Text = firstvalue + " " + op;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToSingle(txtValue.Text);
            op = "×";
            txtValue.Text = "0";
            txtDetails.Text = firstvalue + " " + op;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToSingle(txtValue.Text);
            op = "÷";
            txtValue.Text = "0";
            txtDetails.Text = firstvalue + " " + op;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (op == "")
                return;

            if (!float.TryParse(txtValue.Text, out secondvalue))
            {
                txtValue.Text = "0";
                return;
            }

            float result = 0;

            switch (op)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    break;

                case "-":
                    result = firstvalue - secondvalue;
                    break;

                case "×":
                    result = firstvalue * secondvalue;
                    break;

                case "÷":
                    if (secondvalue == 0)
                    {
                        txtValue.Text = "Cannot divide by zero";
                        txtDetails.Text = firstvalue + " ÷ " + secondvalue + " =";
                        op = "";
                        return;
                    }

                    result = firstvalue / secondvalue;
                    break;

                default:
                    return;
            }

            txtDetails.Text =
                firstvalue + " " + op + " " + secondvalue + " =";

            txtValue.Text = result.ToString();
            op = "";
        }
    }
}
