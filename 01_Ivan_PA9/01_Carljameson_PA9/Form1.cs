using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Carljameson_PA9
{
    public partial class Form1 : Form
    {
        public Double UserInput;
        public Double AmountConverted;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {                             
                UserInput = double.Parse(txt_Amount.Text);
                if (rb_us.Checked)
                {
                    AmountConverted = (UserInput * 0.74);
                    txt_Converted.Text = AmountConverted.ToString();
                }

                else if (rb_yen.Checked)
                {
                    AmountConverted = (UserInput * 81.97);
                    txt_Converted.Text = AmountConverted.ToString();
                }

                else if (rb_ringgit.Checked)
                {
                    AmountConverted = (UserInput * 3.01);
                    txt_Converted.Text = AmountConverted.ToString();
                }

                else
                {
                    txt_Converted.Text = "Please put a correct amount";
                }

                if (UserInput < 0)
                {
                    txt_Converted.Text = "Dont enter negative values";
                }

            }

            catch (FormatException)
            {
                txt_Converted.Text = "Please enter a valid amount";
            }                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_us.Checked = false;
            rb_yen.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_Ringgit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
