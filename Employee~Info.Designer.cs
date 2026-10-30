namespace sharif_programs
{
    partial class Employee_Info
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSectionType = new System.Windows.Forms.ComboBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.btnShowinfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(123, 40);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(518, 32);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // cmbSectionType
            // 
            this.cmbSectionType.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSectionType.FormattingEnabled = true;
            this.cmbSectionType.Items.AddRange(new object[] {
            "~~Section Type~~",
            "Finanace ",
            "Student Office ",
            "HRM",
            "Manegment"});
            this.cmbSectionType.Location = new System.Drawing.Point(126, 201);
            this.cmbSectionType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbSectionType.Name = "cmbSectionType";
            this.cmbSectionType.Size = new System.Drawing.Size(515, 33);
            this.cmbSectionType.TabIndex = 5;
            this.cmbSectionType.SelectedIndexChanged += new System.EventHandler(this.cmbSectionType_SelectedIndexChanged);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnMale.Location = new System.Drawing.Point(136, 326);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(96, 30);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnShowinfo
            // 
            this.btnShowinfo.Location = new System.Drawing.Point(101, 381);
            this.btnShowinfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnShowinfo.Name = "btnShowinfo";
            this.btnShowinfo.Size = new System.Drawing.Size(185, 56);
            this.btnShowinfo.TabIndex = 9;
            this.btnShowinfo.Text = "ShowInfo";
            this.btnShowinfo.UseVisualStyleBackColor = true;
            this.btnShowinfo.Click += new System.EventHandler(this.btnShowinfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone No:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(126, 120);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(515, 32);
            this.txtPhoneNo.TabIndex = 10;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Section Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnFemale.Location = new System.Drawing.Point(260, 326);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(127, 30);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(110, 465);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 25);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "label4";
            this.lblResult.Visible = false;
            // 
            // Employee_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 672);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.btnShowinfo);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.cmbSectionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullName);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Info";
            this.Load += new System.EventHandler(this.Employee_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSectionType;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Button btnShowinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblResult;
    }
}