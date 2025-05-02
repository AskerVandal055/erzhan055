using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace QuaeueExample
{
    public partial class Form1 : Form
    {
        private Queue<string> queue = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string item = txtInput.Text;
                if (!string.IsNullOrEmpty(item))
                {
                    queue.Enqueue(item);
                    txtInput.Clear();
                    MessageBox.Show($"элемент '{item}' добавлен в очередь.");
                }
                else
                {
                    MessageBox.Show("Введите элемент для добавления.");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (queue.Count > 0)
                {
                    string removedItem = queue.Dequeue();
                    MessageBox.Show($"элемент '{removedItem}' удален из очереди.");
                }
                else
                {
                    MessageBox.Show("очередь пуста.");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in queue)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
