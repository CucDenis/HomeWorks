using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Angajat
{
    class Program
    {
        static void Main(string[] args)
        {

            CitireFisier("input.txt");

            Angajat.ListaAngajatilorAlfabetic();

            Console.WriteLine();

            Angajat.ListaAngajatilorDataAngajarii();

        }

        private static void CitireFisier(string v)
        {
            char[] cifre = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            try
            {
                using (StreamReader read = new StreamReader(v))
                {
                    string line;
                    int pozitieSfarsitNume = 0;
                    int pozitieInceputData = 0;
                    bool lineParcursa = false;

                    while ((line = read.ReadLine()) != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (!lineParcursa)
                            {
                                if (line[i] == ' ')
                                {
                                    for (int j = 0; j < cifre.Length; j++)
                                    {
                                        if (line[i + 1] == cifre[j])
                                        {
                                            pozitieSfarsitNume = i;
                                            pozitieInceputData = i+1;
                                            var angajat = new Angajat(AdaugareNume(pozitieSfarsitNume, line),
                                            AdaugareData(pozitieInceputData, line));
                                            lineParcursa = true;
                                            break;
                                        }
                                    }
                                }
                            }else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                File.Create(e.FileName);
            }
        }

        private static DateTime AdaugareData(int pozitieInceputData, string line)
        {
            string date = line.Substring(pozitieInceputData, line.Length-pozitieInceputData);

            DateTime newDate ;
            newDate = Convert.ToDateTime(date);

            return newDate;
        }

        private static string AdaugareNume(int pozitieSfarsitNume, string line)
        {
            string numeComplet;

            numeComplet = line.Substring(0,pozitieSfarsitNume);

            return numeComplet;
        }
    }
}
