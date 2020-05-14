using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda1
{
    class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public Persoana(string Nume, string Prenume)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
        }
    }
}
