using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _7777
{
    class Realestate
    {
        public string address; // адрес
        public string square; // площадь
        public string price; // цена
        public int date; // год выпуска
        public string floor; // этаж
        public string tape_of_floor; // пол
        public void Show()
        {
        Console.WriteLine("просмотр 1");
        }
    }

    class Apartment : Realestate
    {
        public string number_of_rooms; // количество комнат
        public void Show()
        {
            Console.WriteLine("просмотр 2");
        }
    }

    class Garage : Realestate
    {
        public string capacity; // вместимость
        public string construction_type;
        public void Show()
        {
            Console.WriteLine("просмотр 3");
        }
    }

    class House : Realestate
    {
        public int year_built; // год постройки
        public string number_of_rooms; // количество комнат 
        public string price; // цена
       
            public void Show()
        {
            Console.WriteLine("просмотр 4");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Realestate hause1 = new Realestate();
            hause1.address = "moscow yl kirova dom 4";
            hause1.square = "100";
            hause1.price = "10.000.000";
            hause1.date = 2020;

            Apartment apartment2 = new Apartment();
            apartment2.number_of_rooms = "4";
            apartment2.floor = "2";
            apartment2.date = 2023;

            Garage garage3 = new Garage();
            garage3.capacity = "3";
            garage3.construction_type = "kerpich";
            garage3.floor = "beton";
            garage3.date = 2021;
            hause1.Show();
            apartment2.Show();
            garage3.Show();
            Console.ReadLine();





        }
    }
}
