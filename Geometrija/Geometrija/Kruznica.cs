using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrija
{
    class Kruznica
    {
        private Tocka ishodiste = null;
        private double radius;

        public Kruznica()
        {
            this.radius = 10;
            ishodiste = new Tocka();
        }
        public Kruznica(int x, int y, double radius)
        {
            ishodiste = new Tocka(x, y);
            this.radius = radius;
        }

        //getRadius(), setRadius() ...
        public Tocka getIshodiste() { return this.ishodiste; }

        public double udaljenostOd(Kruznica kruznica) //Vraca udaljenost od ishodista kruznice iz argumenta metode
        {
            return ishodiste.distance(kruznica.ishodiste);
        }
    }
}
