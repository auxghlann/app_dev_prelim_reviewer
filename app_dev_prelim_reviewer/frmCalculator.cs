using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_dev_prelim_reviewer
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the Value from a text box

            // Two ways to convert a data type from another datatype

            /// Convert.DataType() method

            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            /// datatype.Parse() method

            //double num1 = double.Parse(txtNum1.Text);
            //double num2 = double.Parse(txtNum2.Text);



            // Calculate the result
            double result = num1 + num2;


            // Display the result to the label
            lblResult.Text = "Result: " + result.ToString();
            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            double result = num1 - num2;

            lblResult.Text = "Result: " + result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            double result = num1 * num2;

            lblResult.Text = "Result: " + result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            double result = num1 / num2;

            lblResult.Text = "Result: "+ result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result: ";
            txtNum1.Clear();
            txtNum2.Clear();

        }
    }
}
