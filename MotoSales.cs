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
    public partial class MotoSales : Form
    {
        public MotoSales()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMoto.SelectedIndex > 0)
            {
                if (cmbMoto.SelectedIndex == 1)
                {
                    txtPrice.Text = "800";
                    txtQuantitiy.Focus();
                }
                else if (cmbMoto.SelectedIndex == 2)

                {
                    txtPrice.Text = "900";
                    txtQuantitiy.Focus();
                }
                else if (cmbMoto.SelectedIndex == 3)
                {
                    txtPrice.Text = "1,200";
                    txtQuantitiy.Focus();
                }
                else if (cmbMoto.SelectedIndex == 4)
                {
                    txtPrice.Text = "3,000";
                    txtQuantitiy.Focus();
                }
                else if (cmbMoto.SelectedIndex == 5)
                {
                    txtPrice.Text = "1,800";
                    txtQuantitiy.Focus();
                }
            }
            else
            {
                txtPrice.Clear();
                txtQuantitiy.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                //validation is required
                float  price, quantity, total, vat, subtotal;
                price = Convert.ToSingle(txtPrice.Text);
                quantity = Convert.ToSingle(txtQuantitiy.Text);

                total = price * quantity;
                vat = total * 0.05f;
                subtotal = total + vat;

                lblMessage.Text ="Total:$" + total + "\n" + "VAT 5%:$" + vat + "\n" +
                    "Sub total:$" + subtotal;
                lblMessage.Visible = true;
                lblMessage.ForeColor = Color.Blue;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Exceptional",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void MotoSales_Load(object sender, EventArgs e)
        {
            {
                cmbMoto.SelectedIndex = 0;

            }
        }

        private void cmbMoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbMoto_DropDown(object sender, EventArgs e)
        {

        }

        private void cmbMoto_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cmbMoto_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
