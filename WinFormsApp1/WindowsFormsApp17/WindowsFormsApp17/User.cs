using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public User(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Город: {City}";
        }
       
    }
}
