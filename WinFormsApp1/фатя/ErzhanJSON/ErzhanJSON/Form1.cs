using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace ErzhanJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = txtName.Text,
                Age = (int)numericUpDownAge.Value,
                Email = txtEmail.Text
            };
            
            string json = JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", json);
            MessageBox.Show("ДАННЫЕ СОХРАНЕНЫ!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                User user = JsonConvert.DeserializeObject<User>(json);
                txtName.Text = user.Name;
                numericUpDownAge.Value = user.Age;
                txtEmail.Text = user.Email;
                MessageBox.Show("данные загружены");
            }
            else
            {
                MessageBox.Show("фаил не найден");
            }
        }
    }
}
