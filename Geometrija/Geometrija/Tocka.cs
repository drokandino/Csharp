using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrija
{
    class Tocka
    {
        private int x, y;

        public Tocka()
        {
            this.x = 0;
            this.y = 0;
        }
        public Tocka(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
        }
        public double distance(Tocka tocka)
        {
            return Math.Sqrt(Math.Pow(tocka.x - this.x, 2) + Math.Pow(tocka.y - this.y, 2));
        }

        public int getX() { return this.x; }
        public int getY() { return this.y; }
        public int[] getXY()
        {
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;
        }

        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }


    }
}
