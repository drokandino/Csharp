using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    interface IKorisnik
    {
        string Id { get; }
        string Name { get; set; }
        int Balance { get; }

        int dodajNaRacun(int vrijednost);
        int oduzmiSaRacuna(int vrijednost);
        int prebaciNa(Korisnik drugi_korisnik, int vrijednost);
        void naknadaZaVodenjeRacuna();
    }
}
