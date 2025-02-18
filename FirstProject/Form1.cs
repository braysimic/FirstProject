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
            try //try block for case of invalid input, such as integer or letter not shown in drop down
            {
                //if the drop down boxes are empty, then error pop up shows
                if (cmbGrade1.SelectedItem == null || cmbGrade2.SelectedItem == null
                || cmbGrade3.SelectedItem == null || cmbGrade4.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all drop down boxes with grades for every class.", "Input Error", MessageBoxButtons.OK);
                    return;
                }
                //converts selected grades to their gpa values
                double gpa1 = GradeConversion(cmbGrade1.SelectedItem.ToString());
                double gpa2 = GradeConversion(cmbGrade2.SelectedItem.ToString());
                double gpa3 = GradeConversion(cmbGrade3.SelectedItem.ToString());
                double gpa4 = GradeConversion(cmbGrade4.SelectedItem.ToString());
                double gpa = (gpa1 + gpa2 + gpa3 + gpa4) / 4; //formula for calculating gpa
                // Display gpa up to two decimals
                lblGpaNumber.Text = gpa.ToString("F2");
                                
                if (gpa >= 3.0) //if gpa is more than 3.0 give positive reactions
                {
                    lblGpaNumber.ForeColor = Color.Green;
                    picGpaHappy.Visible = true;
                    picGpaSad.Visible = false;
                } else //otherwise give different negative reactions
                {
                    lblGpaNumber.ForeColor = Color.Red;
                    picGpaHappy.Visible = false;
                    picGpaSad.Visible = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: Invalid Input","Try Again", MessageBoxButtons.OK);
            }
      
        }

        private double GradeConversion(string grade)
        {
           
            switch(grade) //convert letter grades to their respective gpa values
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
            //clears all the class name textboxes
            txtClassName1.Clear();
            txtClassName2.Clear();
            txtClassName3.Clear();
            txtClassName4.Clear();

            //sets the drop down boxes to show nothing or clear them
            cmbGrade1.SelectedItem = null;
            cmbGrade2.SelectedItem = null;
            cmbGrade3.SelectedItem = null;
            cmbGrade4.SelectedItem = null;

            //resets the label for gpa and sets the color back to normal
            lblGpaNumber.Text = "0.00";
            lblGpaNumber.ForeColor = Color.Black;

            //takes away any of the feedback photos if nessesary
            picGpaHappy.Visible = false;
            picGpaSad.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //show a pop up message before closing
            MessageBox.Show("GPA Calculator closed", "Exit", MessageBoxButtons.OK);
            this.Close();

        }
    }
}
