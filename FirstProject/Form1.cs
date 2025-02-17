using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassName1.Clear();
            txtClassName2.Clear();
            txtClassName3.Clear();
            txtClassName4.Clear();

            cmbGrade1.SelectedIndex = 0;
            cmbGrade2.SelectedIndex = 0;
            cmbGrade3.SelectedIndex = 0;
            cmbGrade4.SelectedIndex = 0;

            lblGpaNumber.Text = "0.0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
