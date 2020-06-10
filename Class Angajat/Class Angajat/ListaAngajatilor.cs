using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Angajat
{
    class ListaAngajatilor<T,U>
    {
        private List<(T, U)> _listaAngajati = new List<(T, U)>();

        public List<(T,U)> ListaAngajati
        {
            get
            {
                return _listaAngajati;
            }

            set
            {
                _listaAngajati = value;
            }
        }

        public (T,U) this[int i]
        {
            get
            {
                return ListaAngajati.ElementAt(i);
            }
        }

        public ListaAngajatilor(int capacity)
        {
            
        }

        public void Add(T t, U u)
        {
            ListaAngajati.Add((t,u));
        }

        public void Remove(T t, U u)
        {
            ListaAngajati.Remove((t,u));
        }

        public void Sort()
        {
            ListaAngajati = ListaAngajati.OrderBy(i => i.Item1).ToList();
            
        }

        public void Sort(string data)
        {
            if(data == "data")
            {
                ListaAngajati = ListaAngajati.OrderByDescending(i => i.Item2).ToList();
            }
        }

    }
}
