using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace ClasaElevi
{
    class Fisier
    {
        public string LinieCitita { get; set; }
        private double sumaNote = 0;
        private double numarNote = 0;
        private ListaElevi TabelElevi = new ListaElevi();

        public Fisier()
        {
            
        }

        public void CitireFisier()
        {
            string line = "";
            string nume = "";
            string prenume = "";
            int counter = 1;
            double limitaNumarNote = 0;

            StreamReader reader = new StreamReader("ListaElevi.txt");
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter == 1)
                    {
                        nume = line;
                        counter++;
                    }
                    else if (counter == 2)
                    {
                        prenume = line;
                        counter++;
                    }
                    else if (counter == 3)
                    {
                        numarNote = double.Parse(line);
                        limitaNumarNote = numarNote + counter;
                        counter++;
                    }
                    else if (counter < limitaNumarNote)
                    {
                        sumaNote += double.Parse(line);
                        counter++;
                    }
                    else if (counter == limitaNumarNote)
                    {
                        sumaNote += double.Parse(line);
                        var elev = new Elev(nume, prenume, MedieNote());
                        TabelElevi.AdaugareElevi(elev);

                        counter = 1;
                        sumaNote = 0;
                        numarNote = 0;
                    }
                }
            }
        }

        public void AfisareFisierNou()
        {
            TabelElevi.SortareElevi();
        }

        private double MedieNote()
        {
            double medie;
            medie = (sumaNote / numarNote);
            return medie;
        }
    }
}
