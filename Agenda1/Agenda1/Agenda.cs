using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda1
{
    class Agenda
    {
        private List<Activitate> _listaDeActivitati = new List<Activitate>();

        public static int numarAgende = 0;
        public string Nume { get; set; }
        public List<Activitate> ListaDeActivitati
        {
            get
            {
                return _listaDeActivitati;
            }
            set
            {
                _listaDeActivitati = value;
            }
        }

        public Agenda(string Nume)
        {
            this.Nume = Nume;
            numarAgende++;
        }

        public void AdaugareActivitate()
        {

            Console.WriteLine("Se adauga o activitate noua");
            Console.WriteLine();
            Console.WriteLine("Numele activitatii: ");
            string nume = Console.ReadLine();

            Console.WriteLine("Descrierea activitatii: ");
            string descriere = Console.ReadLine();

            Console.WriteLine("Ora incepere: ");
            var OraIncepere = new Data(Convert.ToDateTime(Console.ReadLine()));

            Console.WriteLine("Ora terminare: ");
            var OraTerminare = new Data(Convert.ToDateTime(Console.ReadLine()));

            var activitate = new Activitate(nume,descriere,OraIncepere,OraTerminare);
            ListaDeActivitati.Add(activitate);
            Console.WriteLine("Activitate adaugata: "+ activitate.Nume +" care incepe la ora: " + OraIncepere.DataNoua.GetDateTimeFormats());

        }

        public void StergereActivitate(string numeActivitate)
        {
            foreach (var activitate in ListaDeActivitati)
            {
                if(activitate.Nume == numeActivitate)
                {
                    ListaDeActivitati.Remove(activitate);
                    Console.WriteLine("Activitatea " + activitate.Nume + " ce incepe la ora " + activitate.OraIncepere.DataNoua.GetDateTimeFormats() + " a fost stearsa");
                    break;
                }
                else
                {
                    Console.WriteLine("Activitatea nu exista");
                }
            }
        }


    }
}
