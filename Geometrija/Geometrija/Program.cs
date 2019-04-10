using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrija
{
    class Program
    {
        static void Main(string[] args)
        {
            Tocka tacka = new Tocka(1, 1);
            Tocka probna_tocka = null;
            Kruznica kruz = new Kruznica();
            Kruznica kruz2 = new Kruznica(4, 4, 5);
            probna_tocka = kruz.getIshodiste();


            Console.WriteLine(tacka.distance(0, 0) + "\n" + probna_tocka.ToString() + "\n" + kruz.udaljenostOd(kruz2));
          
        }
    }
}
