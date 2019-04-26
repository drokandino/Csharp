using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            Company firma = new Company(Guid.NewGuid(), "Novi list", "Urbana ulica 55", "vat");
            User korisnik = new User(Guid.NewGuid(), Guid.NewGuid(), "Ivana", "Ivic", DateTime.UtcNow, firma);

            SaveService spremac = new SaveService(true);
            LoadService citac = null;
            try
            {
                citac = new LoadService();
            } catch (IOException e) //Kada se uhvati exception metode ne rade??
            {
                Console.WriteLine("File ne postoji!");
            }


            List<User> korisnici = new List<User>();
            List<Company> firme = new List<Company>();

            spremac.AddCompany("Optika Broz", "Nikole Tesle 55", "vat");
            spremac.AddCompany("RiFit", "Nikole Tesle 5", "vat");
            spremac.AddCompany(firma); 

            spremac.AddUser("Bosko", "Bosic", DateTime.UtcNow, LoadService.LoadCompany("Optika Broz"));
            spremac.AddUser("Bosko", "Bosic", DateTime.UtcNow, LoadService.LoadCompany("Rifit"));
            spremac.AddUser(korisnik);
            
            firme = citac.LoadCompanies();
            korisnici = citac.LoadUsers();
            
            korisnici.Add(citac.LoadUser(korisnik.id));

            foreach(Company firhma in firme)
            {
                Console.WriteLine(firhma.name);
            }

            foreach(User user in korisnici)
            {
                Console.WriteLine(user.firstName);
            }
        }
    }
}
