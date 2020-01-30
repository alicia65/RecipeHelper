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
            txtCelsius.Text = (Int) ((txtFahrenheit.Text - 32) * 5 / 9);
            txtFahrenheit.Text = 
        }
    }
}
