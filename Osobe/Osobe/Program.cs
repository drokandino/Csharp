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
            Osoba[] osobe = new Osoba[3];

            osobe[0] = new Osoba("Marica", 22);
            osobe[1] = new Osoba("Ivica", 22);
            osobe[2] = new Osoba("Bozo", 2);
            osobe[0].Starost = 10;
            Console.WriteLine(osobe[0].Starost);
            Console.WriteLine(osobe[0]);

            Osobe osobe_za_iteraciju = new Osobe(osobe);
            foreach(Osoba osoba in osobe_za_iteraciju)
            {
                Console.Write(osoba.Starost);
            }
        }
    }
}
