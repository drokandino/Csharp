using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace Firma
{
    class LoadService
    {
        public LoadService()
        {
            if (!File.Exists(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json") || 
                !File.Exists(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json"))
                throw new IOException();
        }   
        
        public List<Company> LoadCompanies()
        {
            StreamReader citac = null;
            citac = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            List<Company> firme = new List<Company>();

            while (!citac.EndOfStream)
            { 
                firme.Add(JsonConvert.DeserializeObject<Company>(citac.ReadLine()));

            }
            citac.Close();
            return firme;
        }

        public static Company LoadCompany(/*Guid id*/ string name)
        {
            StreamReader citac = null;
            citac = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json");
            Company firma = null;

            while (!citac.EndOfStream)
            {
                firma = JsonConvert.DeserializeObject<Company>(citac.ReadLine());
                // if (firma.id == id) break;
                if (firma.name == name) break;
            }
            citac.Close();
            return firma;
        }

        public List<User> LoadUsers()
        {
            StreamReader citac = null;
            citac = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");
            List<User> korisnici = new List<User>();

            while (!citac.EndOfStream)
            {
                korisnici.Add(JsonConvert.DeserializeObject<User>(citac.ReadLine()));
            }
            citac.Close();
            return korisnici;
        }
        
        public User LoadUser(string name)
        {
            StreamReader citac = null;
            citac = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");
            User korisnik = null;

            while (!citac.EndOfStream)
            {
                korisnik = JsonConvert.DeserializeObject<User>(citac.ReadLine());
                if (korisnik.firstName == name) break;
            }
            citac.Close();

            return korisnik;
        }

        public User LoadUser(Guid id)
        {
            StreamReader citac = null;
            User korisnik = null;
            citac = new StreamReader(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Korisnici.json");

            while (!citac.EndOfStream)
            {
                korisnik = JsonConvert.DeserializeObject<User>(citac.ReadLine());
                if (korisnik.id == id) break;
            }
            citac.Close();

            return korisnik;
        }
    }
}
