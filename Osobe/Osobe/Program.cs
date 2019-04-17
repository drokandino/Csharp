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
            Osoba[] osobe = new Osoba[5];

            osobe[0] = new Osoba("Marica", 60);
            osobe[1] = new Osoba("Ivica", 22);
            osobe[2] = new Osoba("Bozo", 2);
            osobe[3] = new Osoba("Jimi", 24);
            osobe[4] = new Osoba("Ana", 55);
            
            HashSet<Osoba> starije_osobe = new HashSet<Osoba>();
            HashSet<Osoba> mlade_osobe = new HashSet<Osoba>();
            HashSet<Osoba> sve_osobe = new HashSet<Osoba>();

            Osobe osobe_za_iteraciju = new Osobe(osobe);
            foreach(Osoba osoba in osobe_za_iteraciju)
            {
                sve_osobe.Add(osoba);
                if(osoba.Starost < 40) { mlade_osobe.Add(osoba); }
                else { starije_osobe.Add(osoba); }
            }
            starije_osobe.Add(osobe[4]);//Nece ju ponovno dodat u set jer bio onda bio duplikat

            foreach (Osoba osoba in osobe_za_iteraciju)
            {
                if(starije_osobe.Contains(osoba)) { Console.Write(osoba.ToString() + " pripada starijim osobama.\n"); }
                else { Console.Write(osoba.ToString() + " pripada mladim osobama.\n"); }
            }

            sve_osobe.ExceptWith(starije_osobe);
            foreach(Osoba osoba in sve_osobe)
            {
                Console.WriteLine(osoba);
            }
            
        }
    }
}
