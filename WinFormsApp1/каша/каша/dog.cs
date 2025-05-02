using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace каша
{
    public class dog : Animal
    {
        public string Breed { get; set; }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Порода : {Breed}";
        }



    }
}
