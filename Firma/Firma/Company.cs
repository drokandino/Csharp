using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Company
    {
        private Guid Id;
        private string Name, Adress, VAT;
        ICollection<User> Users;

        public Company(Guid Id, string Name, string Adress, string VAT)
        {
            this.Id = Id;
            this.Name = Name;
            this.Adress = Adress;
            this.VAT = VAT;
        }

        public Guid id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string adress
        {
            get { return Adress; }
            set { Adress = value; }
        }
        public string vat
        {
            get { return VAT; }
            set { VAT = value; }
        }
    }
}
