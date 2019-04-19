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
            Company firma = new Company(Guid.NewGuid(), "Optika Broz", "Nikole Tesle 55", "vat");
            User korisnik = new User(Guid.NewGuid(), Guid.NewGuid(), "Bosko", "Bosic", DateTime.UtcNow, firma);
            SaveService spremac = new SaveService();

            spremac.AddCompany(firma);
            spremac.AddUser(korisnik);
        }
    }
}
