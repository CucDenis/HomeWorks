using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda1
{
    class Activitate
    {
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public Data OraIncepere { get; set; }
        public Data OraSfarsit { get; set; }

        public Activitate(string Nume, string Descriere, Data OraIncepere, Data OraSfarsit)
        {
            this.Nume = Nume;
            this.Descriere = Descriere;
            this.OraIncepere = OraIncepere;
            this.OraSfarsit = OraSfarsit;
        }

    }
}
