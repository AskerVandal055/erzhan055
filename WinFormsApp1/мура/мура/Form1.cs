using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мура
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            IShape shape = null;

            if (radioButtonCircle.Checked)


            {
                double radius = double.Parse(txtRadius.Text);
                shape = new Circle(radius);
            }
            else if (radioButtonRectangle.Checked)
            {
                double width = double.Parse(txtWidth.Text);
                double height = double.Parse(txtHeight.Text);
                shape = new Rectangle(width, height);
            }

            if (shape != null)
            {
                lblResult.Text = $"Area of {shape.Name}: {shape.Area()}";
            }
        }
    }
}

