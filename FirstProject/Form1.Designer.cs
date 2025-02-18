namespace FirstProject
{
    partial class GPAForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPAForm));
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtClassName1 = new System.Windows.Forms.TextBox();
            this.txtClassName4 = new System.Windows.Forms.TextBox();
            this.txtClassName3 = new System.Windows.Forms.TextBox();
            this.txtClassName2 = new System.Windows.Forms.TextBox();
            this.cmbGrade1 = new System.Windows.Forms.ComboBox();
            this.cmbGrade4 = new System.Windows.Forms.ComboBox();
            this.cmbGrade3 = new System.Windows.Forms.ComboBox();
            this.cmbGrade2 = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblGpaNumber = new System.Windows.Forms.Label();
            this.picGpaSad = new System.Windows.Forms.PictureBox();
            this.picGpaHappy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGpaSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpaHappy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(195, 19);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(377, 20);
            this.lblInstruction.TabIndex = 11;
            this.lblInstruction.Text = "Enter Name and Letter Grade of Each Class Below: ";
            // 
            // txtClassName1
            // 
            this.txtClassName1.Location = new System.Drawing.Point(28, 87);
            this.txtClassName1.Name = "txtClassName1";
            this.txtClassName1.Size = new System.Drawing.Size(152, 26);
            this.txtClassName1.TabIndex = 0;
            // 
            // txtClassName4
            // 
            this.txtClassName4.Location = new System.Drawing.Point(587, 87);
            this.txtClassName4.Name = "txtClassName4";
            this.txtClassName4.Size = new System.Drawing.Size(157, 26);
            this.txtClassName4.TabIndex = 3;
            // 
            // txtClassName3
            // 
            this.txtClassName3.Location = new System.Drawing.Point(403, 87);
            this.txtClassName3.Name = "txtClassName3";
            this.txtClassName3.Size = new System.Drawing.Size(148, 26);
            this.txtClassName3.TabIndex = 2;
            // 
            // txtClassName2
            // 
            this.txtClassName2.Location = new System.Drawing.Point(213, 87);
            this.txtClassName2.Name = "txtClassName2";
            this.txtClassName2.Size = new System.Drawing.Size(152, 26);
            this.txtClassName2.TabIndex = 1;
            // 
            // cmbGrade1
            // 
            this.cmbGrade1.FormattingEnabled = true;
            this.cmbGrade1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.cmbGrade1.Location = new System.Drawing.Point(38, 142);
            this.cmbGrade1.Name = "cmbGrade1";
            this.cmbGrade1.Size = new System.Drawing.Size(128, 28);
            this.cmbGrade1.TabIndex = 4;
            this.cmbGrade1.Text = "Letter Grade:";
            // 
            // cmbGrade4
            // 
            this.cmbGrade4.FormattingEnabled = true;
            this.cmbGrade4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.cmbGrade4.Location = new System.Drawing.Point(606, 142);
            this.cmbGrade4.Name = "cmbGrade4";
            this.cmbGrade4.Size = new System.Drawing.Size(130, 28);
            this.cmbGrade4.TabIndex = 7;
            this.cmbGrade4.Text = "Letter Grade:";
            // 
            // cmbGrade3
            // 
            this.cmbGrade3.FormattingEnabled = true;
            this.cmbGrade3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.cmbGrade3.Location = new System.Drawing.Point(415, 142);
            this.cmbGrade3.Name = "cmbGrade3";
            this.cmbGrade3.Size = new System.Drawing.Size(125, 28);
            this.cmbGrade3.TabIndex = 6;
            this.cmbGrade3.Text = "Letter Grade:";
            // 
            // cmbGrade2
            // 
            this.cmbGrade2.FormattingEnabled = true;
            this.cmbGrade2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.cmbGrade2.Location = new System.Drawing.Point(227, 142);
            this.cmbGrade2.Name = "cmbGrade2";
            this.cmbGrade2.Size = new System.Drawing.Size(127, 28);
            this.cmbGrade2.TabIndex = 5;
            this.cmbGrade2.Text = "Letter Grade:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(130, 249);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 38);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate GPA";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(537, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGPA.Location = new System.Drawing.Point(10, 343);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(89, 38);
            this.lblGPA.TabIndex = 12;
            this.lblGPA.Text = "GPA:";
            // 
            // lblGpaNumber
            // 
            this.lblGpaNumber.AutoSize = true;
            this.lblGpaNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGpaNumber.CausesValidation = false;
            this.lblGpaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblGpaNumber.Location = new System.Drawing.Point(121, 335);
            this.lblGpaNumber.Name = "lblGpaNumber";
            this.lblGpaNumber.Size = new System.Drawing.Size(99, 48);
            this.lblGpaNumber.TabIndex = 12;
            this.lblGpaNumber.Text = "0.00";
            // 
            // picGpaSad
            // 
            this.picGpaSad.Image = ((System.Drawing.Image)(resources.GetObject("picGpaSad.Image")));
            this.picGpaSad.Location = new System.Drawing.Point(288, 301);
            this.picGpaSad.Name = "picGpaSad";
            this.picGpaSad.Size = new System.Drawing.Size(199, 137);
            this.picGpaSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGpaSad.TabIndex = 13;
            this.picGpaSad.TabStop = false;
            this.picGpaSad.Visible = false;
            // 
            // picGpaHappy
            // 
            this.picGpaHappy.Image = ((System.Drawing.Image)(resources.GetObject("picGpaHappy.Image")));
            this.picGpaHappy.Location = new System.Drawing.Point(288, 301);
            this.picGpaHappy.Name = "picGpaHappy";
            this.picGpaHappy.Size = new System.Drawing.Size(199, 137);
            this.picGpaHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGpaHappy.TabIndex = 14;
            this.picGpaHappy.TabStop = false;
            this.picGpaHappy.Visible = false;
            // 
            // GPAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGpaHappy);
            this.Controls.Add(this.picGpaSad);
            this.Controls.Add(this.lblGpaNumber);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbGrade2);
            this.Controls.Add(this.cmbGrade3);
            this.Controls.Add(this.cmbGrade4);
            this.Controls.Add(this.cmbGrade1);
            this.Controls.Add(this.txtClassName2);
            this.Controls.Add(this.txtClassName3);
            this.Controls.Add(this.txtClassName4);
            this.Controls.Add(this.txtClassName1);
            this.Controls.Add(this.lblInstruction);
            this.Name = "GPAForm";
            this.Text = "Student GPA Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.picGpaSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGpaHappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtClassName1;
        private System.Windows.Forms.TextBox txtClassName4;
        private System.Windows.Forms.TextBox txtClassName3;
        private System.Windows.Forms.TextBox txtClassName2;
        private System.Windows.Forms.ComboBox cmbGrade1;
        private System.Windows.Forms.ComboBox cmbGrade4;
        private System.Windows.Forms.ComboBox cmbGrade3;
        private System.Windows.Forms.ComboBox cmbGrade2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblGpaNumber;
        private System.Windows.Forms.PictureBox picGpaSad;
        private System.Windows.Forms.PictureBox picGpaHappy;
    }
}

