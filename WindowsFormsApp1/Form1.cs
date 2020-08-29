using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            Regex regex = new Regex(@"^-?[0-9]\d*(\.\d+)?$");
            Match match = regex.Match(inputStr);

            
            /* checks if input is empty*/
            if (String.IsNullOrEmpty(inputStr))
            {
                MessageBox.Show("input is empty");
                return;
            }


            if (!(match.Success))
            {
                MessageBox.Show("Enter a valid value.");
                return;
            }

            var input = double.Parse(inputStr);

            var chk = "";
            double output=0.0;
            var noRadioBtnSelected = true;


            if (radioBtn_farToCel.Checked)
            {
                chk = "far to cel";
                output = (input - 32) * (5.0/9);
                noRadioBtnSelected = false;
            }

            if (radioBtn_celToFar.Checked)
            {
                chk = "cel to far";
                output= (input * 9.0 / 5) + 32;
                noRadioBtnSelected = false;
            }

            if (radioBtn_celToKel.Checked)
            {
                chk = "cel to kelvin";
                output = input + 273.15;
                noRadioBtnSelected = false;
            }

            if (radioBtn_kelToCel.Checked)
            {
                chk = "kel to cel";
                output = input - 273.15;
                noRadioBtnSelected = false;
            }

            if (radioBtn_farToKel.Checked)
            {
                chk = "far to kelvin";
                output = (input - 32) * 5.0 / 9 + 273.15;
                noRadioBtnSelected = false;
            }

            if (noRadioBtnSelected)
            {
                MessageBox.Show("Select a method first");
                return;
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "";
            textBox_output.Text= "";

            radioBtn_farToCel.Checked = false;
            radioBtn_celToFar.Checked = false;
            radioBtn_celToKel.Checked = false;
            radioBtn_kelToCel.Checked = false;
            radioBtn_farToCel.Checked = false;

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
