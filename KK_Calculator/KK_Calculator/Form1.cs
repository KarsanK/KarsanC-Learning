using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KK_Calculator
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        string theOperator;
        double total1 = 0;

        private void
Calc_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }
        
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }
                
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
        double num2 = 0;
        double answer = 0;

        private void btnPlus_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "+";
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "-";
            txtDisplay.Clear();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "*";
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "/";
            txtDisplay.Clear();
        }


        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "+";
            txtDisplay.Clear();

            
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

       private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 * double.Parse(txtDisplay.Text);
            

            theOperator = "*";
            txtDisplay.Clear();
        }

       private void btnEquals_Click(object sender, EventArgs e)
       {

           double num2;
           double answer;

           num2 = double.Parse(txtDisplay.Text);

           switch (theOperator)
           {
               case "+":
                   answer = total1 + num2;
                   txtDisplay.Text = answer.ToString();
                   total1 = 0;
                   break;
               case "-":
                   answer = total1 - num2;
                   txtDisplay.Text = answer.ToString();
                   total1 = 0;
                   break;
               case "*":
                   answer = total1 * num2;
                   txtDisplay.Text = answer.ToString();
                   total1 = 0;
                   break;
               case "/":
                   answer = total1 / num2;
                   txtDisplay.Text = answer.ToString();
                   total1 = 0;
                   break;
               default:
                   answer = 0;
                   break;
           }

       }

    }
}
