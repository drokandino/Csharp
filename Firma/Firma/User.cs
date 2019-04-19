using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class User
    {
        private Guid Id, CompanyId;
        private string FirstName, LastName;
        private DateTime DoB;
        private Company Company;

        public User(Guid id, Guid companyId, string name, string surname, DateTime dob, Company company)
        {
            Id = id;
            CompanyId = companyId;
            FirstName = name;
            LastName = surname;
            DoB = dob;
            Company = company;
        }
        
        public Guid id
        {
            get { return Id; }
            set { Id = value; }
        }
        public Guid companyId
        {
            get { return CompanyId; }
            set { CompanyId = value; }
        }
        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public DateTime dob
        {
            get { return DoB; }
            set { DoB = value; }
        }
        public Company company
        {
            get { return Company; }
            set { Company = value; }
        }
    }
}
