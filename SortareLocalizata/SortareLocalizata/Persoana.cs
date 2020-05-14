using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SortareLocalizata
{
    class Persoana
    {
        public string nume;
        public string prenume;
        public string prenume2;
        public string prenume3;

        public Persoana(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }
        public Persoana(string nume, string prenume, string prenume2)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.prenume2 = prenume2;
        }
        public Persoana(string nume, string prenume, string prenume2, string prenume3)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.prenume3 = prenume3;
        }


        public string Capitalizare(string numeIntrodus)
        {
            char[] litere = numeIntrodus.ToCharArray();
            for (int i = 0; i < litere.Length; i++)
            {
                litere[0] = char.ToUpper(litere[0]);
                break;
            }
            numeIntrodus = new string(litere);
            return numeIntrodus;
        }
    }
}
