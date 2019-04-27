using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Firma
{
    class SaveService
    {
        private StreamWriter pisac;

        public  SaveService(Boolean ocisti_datoteke)
        {
            if (ocisti_datoteke == true)
            {
                File.WriteAllText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json", "");
                File.WriteAllText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json", "");
            }
        }

        public void AddCompany(string ime_firme, string adresa, string vat)
        {
            Company firma = new Company(Guid.NewGuid(), ime_firme, adresa, vat);
            pisac = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            pisac.WriteLine(JsonConvert.SerializeObject(firma));
            pisac.Close();
        }

        public void AddCompany(Company firma)
        {
            pisac = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            pisac.WriteLine(JsonConvert.SerializeObject(firma));
            pisac.Close();
        }
        
        public void AddCompany()
        {
            pisac = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            string ime, adresa, vat;

            Console.WriteLine("Ime firme:");
            ime = Console.ReadLine();
            Console.WriteLine("Adresa firme:");
            adresa = Console.ReadLine();
            Console.WriteLine("Vat firme:");
            vat = Console.ReadLine();

            Company firma = new Company(Guid.NewGuid(), ime, adresa, vat); //ovaj objekt firme ostaje nepotreban u memoriji?
            pisac.WriteLine(JsonConvert.SerializeObject(firma));
            pisac.Close();

        }

        public void AddUser(string ime, string prezime, DateTime dob, Company firma)
        {
            User korisnik = new User(Guid.NewGuid(), firma.id, ime, prezime, dob, firma);

            pisac = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");
            pisac.WriteLine(JsonConvert.SerializeObject(korisnik));
            pisac.Close();
        }

        public void AddUser(User korisnik)
        {
            pisac = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");
            pisac.WriteLine(JsonConvert.SerializeObject(korisnik));
            pisac.Close();
        }
        public void AddUser()
        {
            pisac = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");
            string ime, prezime, ime_firme;

            Console.WriteLine("Ime:");
            ime = Console.ReadLine();
            Console.WriteLine("Prezime:");
            prezime = Console.ReadLine();
            Console.WriteLine("Firma:");
            ime_firme = Console.ReadLine();

            Company firma = LoadService.LoadCompany(ime_firme);

            User korisnik = new User(Guid.NewGuid(), firma.id, ime, prezime, DateTime.UtcNow, firma);
            pisac.WriteLine(JsonConvert.SerializeObject(korisnik));
            pisac.Close();

        }
    }
}
