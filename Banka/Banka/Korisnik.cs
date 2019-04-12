using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{ 
    public class Korisnik
    {
        protected string id, name;
        protected int balance = 0;

        public Korisnik(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    
        public Korisnik(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Balance
        {
            get { return Balance; }
        }

        public int dodajNaRacun(int vrijednost)
        {
            if(vrijednost <= 0)
            {
                Console.Write("Ne mozete prebaciti " + vrijednost + " na racun osobe" + Name );
                return -1;
            }
            else { this.balance += vrijednost; }

            return this.balance;
        }

        public int oduzmiSaRacuna(int vrijednost)
        {
            if(vrijednost <= 0 || vrijednost > balance)
            {
                Console.WriteLine("Nepodrzana vrijednost");
                return -1;
            }
            else { this.balance -= vrijednost; }
            return this.balance;
        }
        
        public int prebaciNa(Korisnik drugi_korisnik, int vrijednost)
        {
            this.balance -= vrijednost;
            drugi_korisnik.dodajNaRacun(vrijednost);

            return this.balance;
        }

        public virtual void naknadaZaVodenjeRacuna()
        {
            balance -= 10;
        }

        public override string ToString()
        {
            return id + " " + name + " " + balance.ToString();
        }
    }
}
