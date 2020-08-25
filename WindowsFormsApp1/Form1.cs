using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            var inputStr = textBox_input.Text;

            var input = double.Parse(inputStr);

            var chk = "";
            double output=0.0;


            if (radioBtn_farToCel.Checked)
            {
                chk = "far to cel";
                output = (input - 32) * (5.0/9);
            }

            if (radioBtn_celToFar.Checked)
            {
                chk = "cel to far";
                output= (input * 9.0 / 5) + 32;
            }

            if (radioBtn_celToKel.Checked)
            {
                chk = "cel to kelvin";
                output = input + 273.15;
            }

            if (radioBtn_kelToCel.Checked)
            {
                chk = "kel to cel";
                output = input - 273.15;
            }

            if (radioBtn_farToKel.Checked)
            {
                chk = "far to kelvin";
                output = (input - 32) * 5.0 / 9 + 273.15;
            }

            output = Math.Round(output, 2);
            textBox_output.Text = output.ToString();
            /*MessageBox.Show(chk);*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
