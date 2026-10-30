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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtfirstvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstvalue, secondvalue, sum;
            firstvalue = Convert.ToInt32(txtfirstvalue.Text);
            secondvalue = Convert.ToInt32(txtsecondvalue.Text);
            sum = firstvalue + secondvalue;
            MessageBox.Show("The Sum Result is:" + sum);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float firstvalue, secondvalue, div;
            firstvalue = Convert.ToSingle(txtfirstvalue.Text);
            secondvalue = Convert.ToSingle(txtsecondvalue.Text);
            div = firstvalue / secondvalue;
            MessageBox.Show("The Division Result is:" + div);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int firstvalue, secondvalue, sub;
            firstvalue = Convert.ToInt32(txtfirstvalue.Text);
            secondvalue = Convert.ToInt32(txtsecondvalue.Text);
            sub = firstvalue - secondvalue;
            MessageBox.Show("The Subtraction Result is:" + sub);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int firstvalue, secondvalue, mul;
            firstvalue = Convert.ToInt32(txtfirstvalue.Text);
            secondvalue = Convert.ToInt32(txtsecondvalue.Text);
            mul = firstvalue * secondvalue;
            MessageBox.Show("The Multiplication Result is:" + mul);
        }
    }
}
