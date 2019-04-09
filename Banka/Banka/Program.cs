using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Korisnik joza = new Korisnik("01", "Joza");
            Korisnik ivica = new Korisnik("02", "Ivica");

            joza.dodajNaRacun(200);
            ivica.dodajNaRacun(3000);
            ivica.oduzmiSaRacuna(300);

            ivica.prebaciNa(joza, 700);

            Console.WriteLine(joza);
            Console.WriteLine(ivica);
        }
    }
}
