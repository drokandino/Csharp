using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)     
        {
            string ime = "Isus";
            string prezime = "Krist", rastegnut_string = "   proba   ";
            string uredeni_string = ime.Replace("I", "P");
            uredeni_string = uredeni_string.Replace("s", "k");

            Console.WriteLine(rastegnut_string.TrimStart() + rastegnut_string.TrimEnd() + rastegnut_string.Trim());
            Console.WriteLine($"Hello World! Jos jedan {uredeni_string} {prezime}");// Console.WriteLine("Hello World! jos jedan" + prezime);
            //Console.ReadKey();

            string recenica = "Ovo je recenica!";
            bool sadrzi_slovo_o = recenica.Contains("o");
            Console.WriteLine(sadrzi_slovo_o);
            Console.WriteLine(recenica.Contains("je").ToString() + " " + recenica.Contains("ananas").ToString());

            var names = new List<string>  { "<name>", "DIno", "Darko"};
            names.Add("Isus");
            names[1] = names[1].ToLower();
            foreach(var name in names)
            {
                Console.WriteLine(name + " ");
            }
        }
    }
}
