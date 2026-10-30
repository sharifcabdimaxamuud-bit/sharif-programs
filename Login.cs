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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //validation
            if (txtId.Text == "")
            {
                MessageBox.Show("Enter your student id", "fill Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("enter your student password", "fill empty box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string myId = "222";
            string myPassword = "cs3";
            if (myId == txtId.Text && myPassword == txtPassword.Text)
            {

             Dashboard objdash = new Dashboard();
               objdash.lblStudentId.Text = "Student id:" + txtId.Text;
               objdash.Show();
              this.Hide();


            }
            else
            {
                MessageBox.Show("incorrect id pr password try again", "invalid identity",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtId.Clear();
                txtPassword.Clear();
                txtId.Focus();
            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
