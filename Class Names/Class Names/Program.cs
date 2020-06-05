using System;

namespace Class_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPersoane = new Names();
            listaPersoane.Add("Andrei Marius");
            listaPersoane.Add("Andrei Flavius");
            listaPersoane.Add("Marta");
            listaPersoane.Add("Urs Radu");
            listaPersoane.Add("Veres Rares");
            listaPersoane.Afisare();

            Console.WriteLine(listaPersoane[2]);
            Console.WriteLine(listaPersoane[1132]);
            Console.WriteLine(listaPersoane["Marta"]);
        }
    }
}
