using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 + num2;
            txtResult.Text = result.ToString();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 - num2;
            txtResult.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double result = num1 * num2;
            txtResult.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            if (num2 != 0)
            {
                double result = num2 / num2;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("ошибка: деление на ноль!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtResult.Text = "";

        }
    }
    
}
