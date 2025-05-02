using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cours course = new Cours();
            course.EnrollStudent(new Student { Name = "Alice" });
            MessageBox.Show("Enrolled: " + course.GetStudents()[0].Name);
        }
    }
}
