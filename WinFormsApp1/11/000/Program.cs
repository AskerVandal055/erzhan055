using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000
{
    interface IRealestate
    {
        void show1();
    }

    interface IHause
    {
        void show2();
    }

    class dormitory : IRealestate, IHause
    {
        public void showIHause()
        {
            Console.WriteLine("1");
        }

        public void showIRealestate()
        {
            Console.WriteLine("Implementing IRealestate interface");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            dormitory dorm = new dormitory();
            dorm.showIHause();
            dorm.showIRealestate();
        }
    }
}



