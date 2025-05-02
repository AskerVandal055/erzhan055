using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace _997777
{
    abstract class Cinematography
    {
        public abstract void showTitle();
        public void Show() // Исправлено на заглавную букву
        {
            Console.WriteLine("просмотр фильма");
        }
    }

    class Documentary : Cinematography
    {
        public override void showTitle()
        {
            Console.WriteLine("Просмотр фильма в телевизоре");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Documentary movie2 = new Documentary();
            movie2.showTitle();
            movie2.Show(); // Исправлено: теперь вызов корректный
            Console.ReadKey();
        }
    }
}
