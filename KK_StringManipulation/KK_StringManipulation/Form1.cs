using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KK_StringManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringVar = textBox1.Text;
            textBox1.Text = stringVar.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringTrim = textBox2.Text;
            stringTrim = stringTrim.Trim();
            int stringLength = stringTrim.Length;
            MessageBox.Show(stringLength.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string someText = "Some Text";
            textBox4.Text = someText;
            someText = someText.Insert(5, "more");
            textBox5.Text = someText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string paddingLeft = textBox6.Text;

            paddingLeft = paddingLeft.PadLeft(20,'*');

            textBox6.Text = paddingLeft;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string emailAddress = "enquiery@me.co.uk";
            string result = "";
            result = emailAddress.Substring(6, 4);
            if (result == ".co.uk")
            {MessageBox.Show("Email Address OK");
            }
            else{MessageBox.Show("Bad email Address");
            }
        }

        
    }
}
