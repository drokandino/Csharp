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
            ZlatniKorisnik zlatan = new ZlatniKorisnik("03", "Zaltan", 10000, "prva_razina");

            joza.dodajNaRacun(200);
            ivica.dodajNaRacun(3000);
            ivica.oduzmiSaRacuna(300);

            ivica.prebaciNa(joza, 700);
            zlatan.naknadaZaVodenjeRacuna();

            Console.WriteLine(joza);
            Console.WriteLine(ivica);
            Console.WriteLine(zlatan);
        }
    }
}
