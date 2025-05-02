using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reich1111
{
    public partial class Form1 : Form
    {
        private List <Realestate> hause1 = new List <Realestate>();
        public Form1()
        {
            InitializeComponent();
        }

       
        //private void btnAddBook_Click(object sender, EventArgs e)
        //{
        //    string title = txtTitle.Text;
        //    string author = txtAuthor.Text;
        //    int year = (int)numericUpDownYear.Value;
        //    Book newBook = new Book(title, author, year);
        //    books.Add(newBook);
        //    listBoxBooks.Items.Add(newBook);
        //    txtTitle.Clear();
        //    txtAuthor.Clear();
        //    numericUpDownYear.Value = numericUpDownYear.Minimum;
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string country = txtCountry.Text;
            int date = (int)numericUpDownYear.Value;
            Realestate newRealestate = new Realestate (address, square, price, int date);
            hause1.Add(newRealestate);
            listBoxTanks.Items.Add(newRealestate);
            txtTitle.Clear();
            txtCountry.Clear();
        }

        private void numericUpDownYear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
