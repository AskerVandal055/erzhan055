using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        private List<IShape> shapes = new List<IShape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtRadius.Text))
            {
                double radius;
                if (double.TryParse(txtRadius.Text, out radius))
                {
                    IShape circle = new Circle(radius);
                    shapes.Add(circle);
                    listShapes.Text="";
                }
                else
                {
                    MessageBox.Show("Введите корректное значение радиуса.");
                }
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double side;
                if (double.TryParse(textBox1.Text, out side))
                {
                    IShape square = new Square(side);
                    shapes.Add(square);
                    listShapes.Items.Add(square.GetShapeInfo());
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите корректное значение стороны.");
                }

            }
               else
               {
                MessageBox.Show("Введите радиус или сторону.");
               }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listShapes.SelectedIndex != -1)
            {
                shapes.RemoveAt(listShapes.SelectedIndex);
                listShapes.Items.RemoveAt(listShapes.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите форму для удаления.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
