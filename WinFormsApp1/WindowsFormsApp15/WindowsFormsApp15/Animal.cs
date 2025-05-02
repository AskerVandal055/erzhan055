using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string Speak()
        {
            return "Animal sound";
        }
    }
}
