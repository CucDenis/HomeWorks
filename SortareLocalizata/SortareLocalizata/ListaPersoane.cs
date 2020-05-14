using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.IO;

namespace SortareLocalizata
{
    class ListaPersoane
    {

        public List<string> nume = new List<string>();
        
        public ListaPersoane()
        {

        }


        public void SortarePersoaneLista()
        {
            nume.Sort();
        }

        public void Add(string numeComplet)
        {
            nume.Add(numeComplet);

        }

        public void AfisareFisier()
        {

            using(StreamWriter sw = new StreamWriter("output.txt"))
            {
                foreach (var item in nume)
                {
                   sw.WriteLine(item);
                }
            }
        }

    }
}
