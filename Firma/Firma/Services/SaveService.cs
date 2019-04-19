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
        public void AddCompany(Company firma)
        {
            File.WriteAllText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Firme.json", JsonConvert.SerializeObject(firma));
        }
        public void AddUser(User korisnik)
        {
            File.WriteAllText(@"C:\Users\Dino\source\repos\Firma\Firma\Services\Krisnici.json", JsonConvert.SerializeObject(korisnik));
        }
    }
}
