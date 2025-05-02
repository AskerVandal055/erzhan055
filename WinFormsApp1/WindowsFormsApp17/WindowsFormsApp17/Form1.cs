using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (!int.TryParse(txtAge.Text, out int age))
            {
                lblResult.Text = "Пожалуйста, ввнедите корректный возраст.";
                return;
            }
            string city = txtCity.Text;
            User user = new User(name, age, city);
            lblResult.Text = user.ToString();
        }
    }
}
