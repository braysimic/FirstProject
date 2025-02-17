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
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(195, 19);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(377, 20);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter Name and Letter Grade of Each Class Below: ";
            // 
            // txtClassName1
            // 
            this.txtClassName1.Location = new System.Drawing.Point(28, 87);
            this.txtClassName1.Name = "txtClassName1";
            this.txtClassName1.Size = new System.Drawing.Size(152, 26);
            this.txtClassName1.TabIndex = 1;
            // 
            // txtClassName4
            // 
            this.txtClassName4.Location = new System.Drawing.Point(587, 87);
            this.txtClassName4.Name = "txtClassName4";
            this.txtClassName4.Size = new System.Drawing.Size(157, 26);
            this.txtClassName4.TabIndex = 2;
            // 
            // txtClassName3
            // 
            this.txtClassName3.Location = new System.Drawing.Point(403, 87);
            this.txtClassName3.Name = "txtClassName3";
            this.txtClassName3.Size = new System.Drawing.Size(148, 26);
            this.txtClassName3.TabIndex = 3;
            // 
            // txtClassName2
            // 
            this.txtClassName2.Location = new System.Drawing.Point(213, 87);
            this.txtClassName2.Name = "txtClassName2";
            this.txtClassName2.Size = new System.Drawing.Size(152, 26);
            this.txtClassName2.TabIndex = 4;
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
            this.cmbGrade1.Location = new System.Drawing.Point(44, 142);
            this.cmbGrade1.Name = "cmbGrade1";
            this.cmbGrade1.Size = new System.Drawing.Size(121, 28);
            this.cmbGrade1.TabIndex = 5;
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
            this.cmbGrade4.Size = new System.Drawing.Size(121, 28);
            this.cmbGrade4.TabIndex = 6;
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
            this.cmbGrade3.Size = new System.Drawing.Size(121, 28);
            this.cmbGrade3.TabIndex = 7;
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
            this.cmbGrade2.Size = new System.Drawing.Size(121, 28);
            this.cmbGrade2.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(135, 249);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 31);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate GPA";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(537, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(131, 301);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(47, 20);
            this.lblGPA.TabIndex = 12;
            this.lblGPA.Text = "GPA:";
            // 
            // lblGpaNumber
            // 
            this.lblGpaNumber.AutoSize = true;
            this.lblGpaNumber.Location = new System.Drawing.Point(184, 301);
            this.lblGpaNumber.Name = "lblGpaNumber";
            this.lblGpaNumber.Size = new System.Drawing.Size(31, 20);
            this.lblGpaNumber.TabIndex = 13;
            this.lblGpaNumber.Text = "0.0";
            // 
            // GPAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

