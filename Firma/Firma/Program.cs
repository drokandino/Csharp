using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Company firma = new Company(Guid.NewGuid(), "Optika Broz", "Nikole Tesle 55", "vat");
            User korisnik = new User(Guid.NewGuid(), Guid.NewGuid(), "Bosko", "Bosic", DateTime.UtcNow, firma);*/
            SaveService spremac = new SaveService();
            LoadService citac = new LoadService();

            spremac.AddCompany("Optika Broz", "Nikole Tesle 55", "vat");
            spremac.AddCompany("RiFit", "Nikole Tesle 5", "vat");

            spremac.AddUser("Bosko", "Bosic", DateTime.UtcNow, LoadService.LoadCompany("Optika Broz"));
            spremac.AddUser("Bosko", "Bosic", DateTime.UtcNow, LoadService.LoadCompany("Rifit"));

            List<Company> fimre = citac.LoadCompanies();
            List<User> korisnici = citac.LoadUsers();

            foreach(Company firhma in fimre)
            {
                Console.WriteLine(firhma.name);
            }

            foreach(User korisnik in korisnici)
            {
                Console.WriteLine(korisnik.firstName);
            }
        }
    }
}
