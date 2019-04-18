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


    }
}
