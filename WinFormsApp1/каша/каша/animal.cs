using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace каша
{
    public class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string GetInfo()
        {
            return $"{Name} (возраст : {Age} лет)";
        }

    }
}
