using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
    public class Osoba
    {

        private string ime_prezime;
        private int starost;

        public Osoba()
        {
            this.starost = 0;
            this.ime_prezime = "Nepoznato";
        }

        public Osoba(string ime_prezime, int starost)
        {
            this.starost = starost;
            this.ime_prezime = ime_prezime;
        }

        public void setStarost(int starost) { this.starost = starost; }

        public int getStarost() { return this.starost; }
      //  public override string ToString() { return ime_prezime; }
    }
}
