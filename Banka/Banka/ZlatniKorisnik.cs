using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class ZlatniKorisnik : Korisnik
    {
        private string kategorija;

        public ZlatniKorisnik(string id, string name, int balance, string kategorija) : base(id, name, balance) //Balance protected ili private??
        {
            this.kategorija = kategorija;
        }

        string Kategorija
        {
            set { kategorija = value; }
            get { return kategorija; }
        }

        public override void naknadaZaVodenjeRacuna()
        {
            if (kategorija == "prva_razina") balance -= 100;
            else if (kategorija == "druga_razina") balance -= 200;
        }
        public override string ToString()
        {
            return base.ToString() + kategorija;
        }
    }
}
