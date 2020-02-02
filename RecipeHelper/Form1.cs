/*
*C# program to Convert Fahrenheit to Cesius
* and Millilitres to Cups
*/
   
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp;
            double Fahrenheit;//declare variables temp and Fahrenheit

            temp = double.Parse(txtCelsius.Text);
            if(btnConvertToFahrenheit.Text == "Fahrenheit") 
            {
                Fahrenheit = ((temp - 32) / 1.8);
                txtFahrenheit.Text = Fahrenheit.ToString();//convert text to string
            }
            

        }

        private void btnConvertToCups_Click(object sender, EventArgs e)
        {
            int measurement;
            int Cups;

            measurement = Int32.Parse(txtMillilitres.Text);
            if (btnConvertToCups.Text == "Cups")
            {
                Cups = (measurement / 250);
                txtCups.Text = Cups.ToString();//convert text to string
            }
        }
         
    }
}

