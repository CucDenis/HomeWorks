using System;
using System.Linq;
using System.Reflection.Metadata;

namespace Agenda1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana Denis = new Persoana("Cuc", "Denis");
            Persoana.ListaDePersoane.Add(Denis);

            Persoana Loredana = new Persoana("Loredana", "Padureanu");
            Persoana.ListaDePersoane.Add(Loredana);

            Persoana Solo = new Persoana("Barburas", "Solomon");
            Persoana.ListaDePersoane.Add(Solo);

            bool ruleaza = true;
            Persoana persoanaActuala = Solo;
            string line;

            while (ruleaza)
            {
                Console.WriteLine("Comenzile aplicatiei: ");
                Console.Write("Pentru a crea o agenda tastati: 'new agnd'\n " +
                    "Pentru a crea sterge o agenda tastati: 'del agnd'\n " +
                    "Pentru a crea o activitate tastati: 'new actte'\n " +
                    "Pentru a sterge o activitate tastati: 'del actte'\n" +
                    "Pentru a orpi aplicatia tastati: 'over'\n");

                line = Console.ReadLine();

                if (line == "new agnd")
                {
                    persoanaActuala = PersoanaActuala();
                    Console.WriteLine("Numele agendei: ");
                    string numeAgenda = Console.ReadLine();
                    persoanaActuala.CreareAgenda(numeAgenda);
                }
                else if (line == "del agnd")
                {
                    persoanaActuala = PersoanaActuala();
                    Console.WriteLine("Numele agendei: ");
                    string numeAgenda = Console.ReadLine();
                    persoanaActuala.StergereAgenda(numeAgenda);
                }
                else if (line == "new actte")
                {
                    Console.WriteLine("Numele agendei: ");
                    string numeAgenda = Console.ReadLine();
                    var agenda = AgendaCurenta(numeAgenda, persoanaActuala);
                    agenda.AdaugareActivitate();
                    
                }
                else if (line == "del actte")
                {
                    Console.WriteLine("Numele agendei: ");
                    string numeAgenda = Console.ReadLine();
                    string numeActivitate = Console.ReadLine();
                    var agenda = AgendaCurenta(numeAgenda, persoanaActuala);
                    agenda.StergereActivitate(numeActivitate);
                }
                else if (line == "over")
                {
                    ruleaza = false;
                    break;
                }
            }
        }

        private static Agenda AgendaCurenta(string numeAgenda, Persoana persoanaActuala)
        {
            foreach (var agenda in persoanaActuala.ListaDeAgende)
            {
                if(agenda.Nume == numeAgenda)
                {
                    return agenda;
                }
            }
            return null;
        }

        private static Persoana PersoanaActuala()
        {
            Console.WriteLine("Alegeti persoana la care se realizeaza modificarile tastand numarul de ordine in lista (numerele de ordine incep de la 0): ");
            int numarOrdine = int.Parse(Console.ReadLine());
            for (int i = 0; i < Persoana.ListaDePersoane.Count; i++)
            {
                if (i == numarOrdine)
                {
                   var persoanaActuala = Persoana.ListaDePersoane.ElementAt(i);
                    return persoanaActuala;
                }
            }
            return null;
        }
    }
}
