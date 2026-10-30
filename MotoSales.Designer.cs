namespace sharif_programs
{
    partial class MotoSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMoto = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtQuantitiy = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMoto
            // 
            this.cmbMoto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmbMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoto.Enabled = false;
            this.cmbMoto.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoto.FormattingEnabled = true;
            this.cmbMoto.Items.AddRange(new object[] {
            "~~ Select MOTO ~~",
            "Motorcycle",
            "Scooter",
            "Electric Motorcycle",
            "Tricycle",
            "Cargo Tricycle"});
            this.cmbMoto.Location = new System.Drawing.Point(28, 138);
            this.cmbMoto.Name = "cmbMoto";
            this.cmbMoto.Size = new System.Drawing.Size(619, 42);
            this.cmbMoto.TabIndex = 0;
            this.cmbMoto.TabStop = false;
            this.cmbMoto.UseWaitCursor = true;
            this.cmbMoto.DropDown += new System.EventHandler(this.cmbMoto_DropDown);
            this.cmbMoto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbMoto.DropDownClosed += new System.EventHandler(this.cmbMoto_DropDownClosed);
            this.cmbMoto.TabStopChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cmbMoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmbMoto_DragDrop);
            this.cmbMoto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbMoto_MouseDoubleClick);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCustomerName.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(28, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(619, 42);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQuantitiy
            // 
            this.txtQuantitiy.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantitiy.Location = new System.Drawing.Point(28, 325);
            this.txtQuantitiy.Name = "txtQuantitiy";
            this.txtQuantitiy.Size = new System.Drawing.Size(619, 42);
            this.txtQuantitiy.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(28, 232);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(619, 42);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.Location = new System.Drawing.Point(160, 387);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(246, 58);
            this.btnCalculateTotal.TabIndex = 5;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Moto~Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantitiy";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(78, 481);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(102, 34);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "label5";
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.label5_Click);
            // 
            // MotoSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 760);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantitiy);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.cmbMoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MotoSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotoSales";
            this.Load += new System.EventHandler(this.MotoSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMoto;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtQuantitiy;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
    }
}