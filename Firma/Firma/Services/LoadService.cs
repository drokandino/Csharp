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
    class LoadService
    {
        public List<Company> LoadCompanies()
        {
            StreamReader file = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            List<Company> firme = new List<Company>();

            while (!file.EndOfStream)
            { 
                firme.Add(JsonConvert.DeserializeObject<Company>(file.ReadLine()));

            }
            file.Close();
            return firme;

        }
        public static Company LoadCompany(/*Guid id*/ string name)
        {
            StreamReader file = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            Company firma = null;

            while (!file.EndOfStream)
            {
                firma = JsonConvert.DeserializeObject<Company>(file.ReadLine());
                // if (firma.id == id) break;
                if (firma.name == name) break;
            }

            return firma;
        }
        public List<User> LoadUsers()
        {
            StreamReader file = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");
            List<User> korisnici = new List<User>();

            while (!file.EndOfStream)
            {
                korisnici.Add(JsonConvert.DeserializeObject<User>(file.ReadLine()));
            }
            file.Close();
            return korisnici;
        }
    }
}
