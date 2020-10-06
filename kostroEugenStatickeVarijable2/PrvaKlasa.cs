using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenStatickeVarijable2
{
    class PrvaKlasa
    {
        private static int brojac;
        private string ime;
        private string prezime;

        public PrvaKlasa()
        {
            brojac++;

        }
        public PrvaKlasa(string ime, string prezime)
        {
            brojac++;
            this.ime = ime;
            this.prezime = prezime;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public int Brojac()
        {
            return brojac;
        }

        public override string ToString()
        {
            string ispis = "Redni broj: " + brojac+", "+Ime+" "+prezime;

            return ispis;

            
            
        }
    }
}
