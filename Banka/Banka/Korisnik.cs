﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{ 
    public class Korisnik
    {
        private string id, name;
        private int balance = 0;

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

        public string getId() { return id; }
        public string getName() { return name; }
        public int getBalance() { return balance; }

        public int dodajNaRacun(int vrijednost)
        {
            if(vrijednost <= 0)
            {
                Console.Write("Ne mozete prebaciti " + vrijednost + " na racun osobe" + this.getName() );
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

        public override string ToString()
        {
            return id + " " + name + " " + balance.ToString();
        }
    }
}