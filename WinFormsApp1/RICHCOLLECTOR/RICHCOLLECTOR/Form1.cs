using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RICHCOLLECTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);

            Point point = new Point(x, y);

            labelPointInfo.Text = point.ToString();

        }
    }
}
