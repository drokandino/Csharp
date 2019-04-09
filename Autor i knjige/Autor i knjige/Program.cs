using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autor_i_knjige
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor[] autori = new Autor[2];

            autori[0] = new Autor("Miroslav", "miro@net.com", 'm');
            autori[1] = new Autor("Mirna", "mirna@net.com", 'f');

            Knjiga prva = new Knjiga("Ljepotica i crv", autori, 120);

            Console.WriteLine(prva.ToString());

        }
    }
}
