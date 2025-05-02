using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            comboBoxAnimalType.Items.Add("Dog");
            comboBoxAnimalType.Items.Add("Cat");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int age = (int)numericUpDownAge.Value;
            Animal animal = null;
            if (comboBoxAnimalType.SelectedItem.ToString() == "Dog")
            {
                animal = new Dog { Name = name, Age=age };
            }
            else if (comboBoxAnimalType.SelectedItem.ToString() == "Cat")
            {
                animal = new Cat { Name = name, Age = age };
            }
            if (animal != null)
            {
                animals.Add(animal);
                listBoxAnimals.Items.Add($"{animal.Name}, {animal.Age} years ald, says {animal.Speak()}");
            }



        }
    }
}
