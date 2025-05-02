using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
            public Form2(string name, string age)
            {
                InitializeComponent();
                lblName.Text = "имя: " + name;
                lblAge.Text = "возраст:" + age;


            }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }

    
   
}
