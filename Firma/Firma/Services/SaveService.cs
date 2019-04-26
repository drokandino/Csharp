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

        public virtual void AddCompany(string ime_firme, string adresa, string vat)
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
    }
}
