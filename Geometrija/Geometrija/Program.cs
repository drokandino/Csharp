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
            Cilindar valjak = new Cilindar(4, 10);

            probna_tocka = kruz.Ishodiste;
            

            Console.WriteLine(tacka.distance(0, 0) + "\n" + probna_tocka.ToString() + "\n" + kruz.udaljenostOd(kruz2));
            Console.WriteLine(valjak.volume()+ "\n" + probna_tocka.X.ToString());
            probna_tocka.Y = 22;
            probna_tocka.X = 5;
            Console.WriteLine(probna_tocka.ToString());
        }
    }
}
