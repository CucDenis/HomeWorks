using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Angajat
{
    class Angajat : IAngajat
    {
        private static  ListaAngajatilor<string, DateTime> _listaNumeDataAngajat = new ListaAngajatilor<string, DateTime>(9);


        public string NumePrenume { get; set; }
        public DateTime DataAngajarii { get; set; }

        public static ListaAngajatilor<string, DateTime> ListaNumeDataAngajare
        {
            get
            {
                return _listaNumeDataAngajat;
            }
            set
            {
                _listaNumeDataAngajat = value;
            }
        }

        public Angajat(string numePrenume, DateTime dataAngajarii)
        {
            ListaNumeDataAngajare.Add(numePrenume,dataAngajarii);
        }

        public static void ListaAngajatilorAlfabetic()
        {
            ListaNumeDataAngajare.Sort();
            using (StreamWriter write = new StreamWriter("alfabetic.txt"))
            {
                foreach (var item in ListaNumeDataAngajare.ListaAngajati)
                {
                    write.WriteLine(item.Item1);
                }
            }
        }

        public static void ListaAngajatilorDataAngajarii()
        {
            ListaNumeDataAngajare.Sort("data");
            using (StreamWriter write = new StreamWriter("dataInvers.txt"))
            {
                foreach (var item in ListaNumeDataAngajare.ListaAngajati)
                {
                    write.WriteLine(item);
                }
            }
        }
    }
}
