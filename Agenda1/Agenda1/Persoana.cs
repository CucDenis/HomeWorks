using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda1
{
    class Persoana
    {
        private List<Agenda> _listaDeAgende = new List<Agenda>();
        private static List<Persoana> _listaDePersoane = new List<Persoana>();

        public string Nume { get; set; }
        public string Prenume { get; set; }

        public List<Agenda> ListaDeAgende
        {
            get
            {
                return _listaDeAgende;
            }
            set
            {
                _listaDeAgende = value;
            }
        }

        public static List<Persoana> ListaDePersoane
        {
            get
            {
                return _listaDePersoane;
            }
            set
            {
                _listaDePersoane = value;
            }
        }

        public Persoana(string Nume, string Prenume)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
        }

        public void CreareAgenda(string NumeAgenda)
        {
            var agenda = new Agenda(NumeAgenda);
            ListaDeAgende.Add(agenda);
            Console.WriteLine("Agenda noua creata: " + NumeAgenda);
        }

        public void StergereAgenda(string NumeAgenda)
        {
            foreach (var agenda in ListaDeAgende)
            {
                if(agenda.Nume == NumeAgenda)
                {
                    ListaDeAgende.Remove(agenda);
                    Console.WriteLine("Agenda " + agenda.Nume + " a fost stearsa");
                    break;
                }
                else
                {
                    Console.WriteLine("Agenda nu exista");
                }
            }
        }

        /*public void VerificareAgende()
        {
            foreach (var agenda in ListaDeAgende)
            {

            }
        }*/
    }
}
