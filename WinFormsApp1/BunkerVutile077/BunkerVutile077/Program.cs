using BunkerVutile077;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace BunkerVutile077
{
    class Realestate
    {
        public string address; // адрес
        public int square;  // площадь
        public int numberfsquares;  // количество квадратов 
        public int data; // год выпуска
        public Realestate(string Address, int Square, int Numberfsquares, int Data)
        {
            this.address = Address;
            this.square = Square;
            this.numberfsquares = Numberfsquares;
            this.data = Data;
        }
        public void ShowAddress()
        {
            Console.WriteLine(address);
            Console.ReadLine();
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Realestate Hause1 = new Realestate("moscow", 100, 200, 2009);
            Hause1.ShowAddress();
        }
    }
}