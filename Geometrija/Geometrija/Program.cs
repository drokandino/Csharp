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
            Console.WriteLine(tacka.distance(0, 0));
        }
    }
}
