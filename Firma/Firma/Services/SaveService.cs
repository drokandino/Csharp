using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Firma
{
    class SaveService
    {   
        public void AddCompany(string ime_firme, string adresa, string vat)
        {
            Company firma = new Company(Guid.NewGuid(), ime_firme, adresa, vat);
            StreamWriter file = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");

            file.WriteLine(JsonConvert.SerializeObject(firma));

            file.Close();
      
        }
        public void AddUser(string ime, string prezime, DateTime dob, Company firma)
        {
            User korisnik = new User(Guid.NewGuid(), firma.id, ime, prezime, dob, firma);
            StreamWriter file = File.AppendText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");

            file.WriteLine(JsonConvert.SerializeObject(korisnik));

            file.Close();
        }
    }
}
