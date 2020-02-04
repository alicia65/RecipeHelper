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
            double temp;//declare variable temp
            double Fahrenheit;//declare variable Fahrenheit

            if (double.TryParse(txtCelsius.Text, out Fahrenheit))
           
            {
                Fahrenheit = temp * 9/5 + 32;//convert Celsius to Fahrenheit
                //Fahrenheit = ((temp - 32) / 1.8);
                txtFahrenheit.Text = Fahrenheit.ToString();//convert text to string
            }
            else 
            {
                MessageBox.Show("Enter only number", "Error");
            }
        }

        private void btnConvertToCups_Click(object sender, EventArgs e)
        {
            double measurement;
            double Cups;

            if (double.TryParse(txtMillilitres.Text, out Cups))
            {
                Cups = (measurement / 250);
                txtCups.Text = Cups.ToString();//convert text to string
            }
        }
         
    }
}

