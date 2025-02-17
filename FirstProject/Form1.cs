using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class GPAForm : Form
    {
        public GPAForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double gpa1 = GradeConversion(cmbGrade1.SelectedItem?.ToString());
            double gpa2 = GradeConversion(cmbGrade1.SelectedItem?.ToString());
            double gpa3 = GradeConversion(cmbGrade1.SelectedItem?.ToString());
            double gpa4 = GradeConversion(cmbGrade1.SelectedItem?.ToString());
            double gpa = (gpa1 + gpa2 + gpa3 + gpa4) / 4;

            lblGpaNumber.Text = $"{gpa:F2}";
        }

        private double GradeConversion(string grade)
        {
            switch(grade)
            {
                case "A":
                    return 4.0;
                case "B":
                    return 3.0;
                case "C":
                    return 2.0;
                case "D":
                    return 1.0;
                case "F":
                    return 0.0;
                default:
                    return 0.0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassName1.Clear();
            txtClassName2.Clear();
            txtClassName3.Clear();
            txtClassName4.Clear();

            cmbGrade1.SelectedIndex = -1;
            cmbGrade2.SelectedIndex = -1;
            cmbGrade3.SelectedIndex = -1;
            cmbGrade4.SelectedIndex = -1;

            lblGpaNumber.Text = "0.0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
