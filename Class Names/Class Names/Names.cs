using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Names
{
    class Names
    {
        private string[] _listaNume = new string[lungime];
        private static int lungime = 10;
        private int i = 0;


        public string this[int index]      
        {
            get
            {
                string tmp = "";
                try
                {
                    if (index >= 0 && index <= ListaNume.Length - 1)
                    {
                        tmp = ListaNume[index];
                    }
                }
                catch(IndexOutOfRangeException e)
                {
                    tmp = e.Message;
                }

                return (tmp);
            } 
            set
            {
                ListaNume[index] = value;
            }
        }


        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < ListaNume.Length)
                {
                    if (ListaNume[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }

        }


        public string[] ListaNume
        {
            get
            {
                return _listaNume;
            }

            set
            {
                _listaNume = value;
            }
        }


        public Names()
        {
            for (int index = 0; index < ListaNume.Length; index++)
            {
                ListaNume[index] = "Nume Nou";
            }
        }

        public void Add(string name)
        {
            if (i >= 0 && i < ListaNume.Length)
            {
                ListaNume[i] = name;
                i++;
            }
        }

        public void Afisare()
        {
            foreach (var item in ListaNume)
            {
                Console.WriteLine(item);
            }
        }

    }
}
