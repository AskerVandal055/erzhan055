using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _777опера
{
    public partial class txtTitle : Form
    {

        private List<Book> books = new List<Book>();
        public txtTitle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string title = textBox1.Text;
            string author = txtAuthor.Text;
            int year = (int)numericUpDownYear.Value;
            Book newBook = new Book(title, author, year);
            books.Add(newBook);
            listBoxBooks.Items.Add(newBook);
            textBox1.Clear();
            txtAuthor.Clear();
            numericUpDownYear.Value = numericUpDownYear.Minimum;
        }
    }
}
