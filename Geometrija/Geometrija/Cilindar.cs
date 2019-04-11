using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrija
{
    class Cilindar : Kruznica
    {
        private double visina = 1;

        public Cilindar(int radius, int visina)
        {
            this.radius = radius;
            this.visina = visina;
        }
        
        public double volume() { return this.radius * 3.14 * this.visina; }
    }
}
