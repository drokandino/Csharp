using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba prva = new Osoba("Marica", 22);
            prva.Starost = 10;
            Console.WriteLine(prva.Starost);
            Console.WriteLine(prva);
        }
    }
}
