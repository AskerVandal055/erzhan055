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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Deportaments.Add(new Deportament { Name = "HR" });
            MessageBox.Show("Deportament added:" + company.Deportaments[0].Name);


        }
    }
}
