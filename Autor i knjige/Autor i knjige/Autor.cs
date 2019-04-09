using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autor_i_knjige
{
    class Autor
    {
        private string name, email;
        private char gender;

        public Autor(string name, string email, char gender)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }

        public string getName() { return this.name; }
        public string getEmail() { return this.email; }
        public char getgender() { return this.gender; }

        public string setEmail(string email)
        {
            this.email = email;
            return this.email;
        }

        public override string ToString()
        {
            return name + " " + email + " " + gender;
        }
    }
}
