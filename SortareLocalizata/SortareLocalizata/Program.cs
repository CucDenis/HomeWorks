using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;


namespace SortareLocalizata
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            ListaPersoane lista = new ListaPersoane();

            List<string> numeNou = new List<string>();
            numeNou.Add(line);

            string nume = "";
            string numeFamilie = "";
            string prenume = "";
            string prenume2 = "";
            string prenume3 = "";
            int ordine = 0;
            bool prost = true;
            bool Solomon = false;

            Console.WriteLine("Este Solomon prost?");
           
            if(Solomon)
            {
                prost = false;
            }
            else
            {
                Console.WriteLine("Este Solomon!");
            }

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {

                    numeNou.Add(line);

                }
            }


            foreach (var item in numeNou)
            {
                string newLine = item;

                for (int y = 0; y < newLine.Length; y++)
                {
                     if (newLine[y] == ' ' || y == newLine.Length)
                     {
                        if(ordine == 0)
                        {
                            numeFamilie = nume;
                            nume = "";
                            ordine++;
                        }else if(ordine == 1)
                        {
                            prenume = nume;
                            nume = "";
                            ordine++;
                        }
                        else if(ordine == 2)
                        {
                            prenume2 = nume;
                            nume = "";
                            ordine++;
                        }
                        else if(ordine == 3)
                        {
                            prenume3 = nume;
                            nume = "";
                            ordine++;
                        }
                     }
                     else
                     {
                        nume = nume + newLine[y];
                        if (ordine == 2)
                        {
                            prenume2 = nume;
                        }
                        else if (ordine == 3)
                        {
                            prenume3 = nume;
                        }
                    }
                }
                if(ordine == 1)
                {
                    prenume = nume;
                    prenume2 = "";
                    prenume3 = "";
                }
                else if(ordine == 2)
                {
                    prenume3 = "";
                }

                Persoana persoana = new Persoana(numeFamilie, prenume, prenume2, prenume3);
                persoana.nume = persoana.Capitalizare(numeFamilie);
                persoana.prenume = persoana.Capitalizare(prenume);
                persoana.prenume2 = persoana.Capitalizare(prenume2);
                persoana.prenume3 = persoana.Capitalizare(prenume3);

                string numeIntreg = persoana.nume + " " + persoana.prenume + " " + persoana.prenume2 + " " + persoana.prenume3;
                lista.Add(numeIntreg);
                nume = "";
                ordine = 0;
            }
            lista.SortarePersoaneLista();

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {

                    numeNou.Add(line);

                }
            }
            lista.AfisareFisier();
        }


    }
}
