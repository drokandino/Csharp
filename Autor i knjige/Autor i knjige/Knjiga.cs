using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autor_i_knjige
{
    class Knjiga
    {
        private string name;
        private Autor[] autor = new Autor[] { };
        private double price;
        private int quantity;

        public  Knjiga(string name, Autor[] autor, double price)
        {
            this.name = name;
            this.autor = autor;
            this.price = price;       
        }
        public Knjiga(string name, Autor[] autor, double price, int quantity)
        {
            this.name = name;
            this.autor = autor;
            this.price = price;
            this.quantity = quantity;
        }

        public string getName() { return this.name; }
        public Autor GetAutor(int index) {
            return autor[index];
        }
        public double getPrice() { return this.price; }
        public int getQuantity() { return this.quantity; }

        public void setPrice(double price) { this.price = price; }
        public void setQuantity(int quantity) { this.quantity = quantity; }

        public override string ToString()
        {
            foreach(Autor pisac in autor)
            {
                Console.WriteLine(pisac.ToString());
            }
            return name +  " " + price.ToString();
        }
    }
}
