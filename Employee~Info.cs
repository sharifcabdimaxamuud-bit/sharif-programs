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
    public partial class Employee_Info : Form
    {
        public string Gender { get; private set; }

        public Employee_Info()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSectionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowinfo_Click(object sender, EventArgs e)
        {
            string fullname, section, phone;
            fullname = txtFullName.Text;
            phone = txtPhoneNo.Text;
            section = cmbSectionType.Text;
            if (rbtnMale.Checked == true)
                Gender = rbtnMale.Text;//male
            else if (rbtnFemale.Checked == true)
                Gender = rbtnFemale.Text;

            lblResult.Text = "Full Name:" + fullname + "\n" +
                "Phone No:" + phone + "\n" + "Section Type:" + section + "\n"
                + "Gender:" + Gender;
            lblResult.Visible = true;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Info_Load(object sender, EventArgs e)
        {
            cmbSectionType.SelectedIndex = 0;
        }
    }
}
