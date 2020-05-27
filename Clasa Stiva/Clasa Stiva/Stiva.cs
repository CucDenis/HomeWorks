using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasa_Stiva
{
    class Stiva
    {
        private List<int> stivaI = new List<int>();
        private List<string> stivaS = new List<string>();
        private int lungime;
        private int MAX = 1000000;
        private int i;


        public List<int> P_IStiva
        {
            get
            {
                return stivaI;
            }
            set
            {
                stivaI = value;
            }
        }

        public List<string> P_SStiva
        {
            get
            {
                return stivaS;
            }
            set
            {
                stivaS = value;
            }
        }


        public Stiva(int lungimeStiva)
        {
            if (lungimeStiva < MAX)
            {
                lungime = lungimeStiva;
            }else
            {
                Console.WriteLine("Lungime stiva depasita.\n" +
                                  "Lungime stiva maxima: 1000000");
            }
        }

        public void Push(int valoare)
        {
            P_IStiva.Add(valoare);
        }

        public void Push(string valoare)
        {
            P_SStiva.Add(valoare);
        }

        public string Pop()
        {
            try
            {
                if (P_IStiva.Count != 0)
                {
                    string valoareActuala = (P_IStiva[P_IStiva.Count - 1]).ToString();
                    P_IStiva.RemoveAt(P_IStiva.Count - 1);
                    return valoareActuala;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("A aparut aceasta exceptie: {0}", e);
            }
            return "\t"; ;
        }

        public string Pop(string tipStiva)
        {
            if(tipStiva == "string")
            {
                try
                {
                    if (P_SStiva.Count != 0)
                    {
                        string valoareActuala = (P_SStiva[P_SStiva.Count - 1]).ToString();
                        P_SStiva.RemoveAt(P_SStiva.Count - 1);
                        return valoareActuala;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("A aparut aceasta exceptie: {0}", e);
                }
            }
            return "\t";
        }

        public void Clear()
        {
            for (int i = 0; i < P_IStiva.Count; i++)
            {
                P_IStiva.Remove(P_IStiva[i]);
            }
        }

        public void Clear(string tipStiva)
        {
            if (tipStiva == "string")
            {
                for (int i = 0; i < P_SStiva.Count; i++)
                {
                    P_SStiva.Remove(P_SStiva[i]);
                }
            }
        }
    }
}
