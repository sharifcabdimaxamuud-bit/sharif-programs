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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login objlogin = new Login();
            objlogin.Show();
            this.Hide();
        }

        private void operatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objop = new Form1();
            objop.Show();

        }

        private void emToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Info objemp = new Employee_Info();
            objemp.Show();

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator objcal = new Calculator();
            objcal.Show();
        }

        private void motoSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotoSales objmoto = new MotoSales();
            objmoto.Show();
        }
    }
}
