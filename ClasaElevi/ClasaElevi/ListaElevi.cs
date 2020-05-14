using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasaElevi
{
    class ListaElevi
    {
        private List<Elev> _tabel = new List<Elev>();

        public List<Elev> Tabel { 
            get 
            {
                return _tabel;
            }
            set
            {
                _tabel = value;
            }
        }

        public ListaElevi()
        {

        }

        public void AdaugareElevi(Elev elev)
        {
            Tabel.Add(elev);
        }


        public void SortareElevi()
        {
            var TabelOrdonat = Tabel.OrderByDescending(s => s.MediaNote).ThenBy(s => s.NumeElev).ThenBy(s => s.PrenumeElev);

            Console.WriteLine("Tabel Elevi");

            foreach (var elev in TabelOrdonat)
            {
                Console.WriteLine(elev.NumeElev + " " + elev.PrenumeElev + " " + elev.MediaNote);
            }
        }
    }
}
