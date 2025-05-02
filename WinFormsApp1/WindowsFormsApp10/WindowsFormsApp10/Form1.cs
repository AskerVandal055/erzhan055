using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class txtAuthor : Form
    {
        private List<Book> books = new List<Book>();

        public txtAuthor()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = textAuthor.Text,
                Year = (int)numYear.Value
            };
               books.Add(newBook);
               UpdateBookList();

        }
        private void UpdateBookList()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                books.Remove((Book)lstBooks.SelectedItem);
                UpdateBookList();
            }
        }
    }
}
