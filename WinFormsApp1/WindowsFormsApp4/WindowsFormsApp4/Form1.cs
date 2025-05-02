using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public delegate void ChangeTextDelegate(String newText);



        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeText(string newText)
          {
            label1.Text=newText;
          }



        private void button1_Click(object sender, EventArgs e)
        {

        ChangeTextDelegate ChangeTextDel = ChangeText;

        ChangeTextDel("Текст изменен");


        }
    }
}
