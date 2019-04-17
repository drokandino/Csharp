using System;
using System.Collections;
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

        public int Starost
        {
            get { return starost; }
            set { starost = value; }
        }
      
        public override string ToString() { return ime_prezime + " " + starost; }
    }

    public class Osobe : IEnumerable //Koristi se samo za iteraciju kroz listu
    {
        private Osoba[] osobe;

        public Osobe(Osoba[] osobe_array)
        {
            osobe = new Osoba[osobe_array.Length];
            for (int i = 0; i < osobe.Length; i++)
            {
                osobe[i] = osobe_array[i];
            }
        }
        //Nije mi jasna implementacija enumeratora
        //Korsiti se kako bi radio foreach()
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public OsobeEnum GetEnumerator()
        {
            return new OsobeEnum(osobe);
        }
    }
    public class OsobeEnum : IEnumerator
    {
        public Osoba[] osobe;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public OsobeEnum (Osoba[] list)
        {
            osobe = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < osobe.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Osoba Current
        {
            get
            {
                try
                {
                    return osobe[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

