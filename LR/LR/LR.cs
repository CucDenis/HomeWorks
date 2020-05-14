using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LR
{
    class LR
    {
        private int contorL = 0;
        private int contorR = 0;
        private string sir;

        public LR()
        {

        }

        public string Read()
        {
            using (StreamReader sr = new StreamReader("TestFile.txt"))
            {
                String line = sr.ReadToEnd();
                this.sir = line;
                return line;
            }
        }

        public int Left()
        {
            char[] sirCaractere = this.sir.ToCharArray();
            bool toateMaiMici = true;

            for (int i = 1; i <= sirCaractere.Length - 1; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if(sirCaractere[j] > sirCaractere[i])
                    {
                        toateMaiMici = false;
                        break;
                    }
                }
                if(toateMaiMici)
                {
                    contorL++;
                }
                toateMaiMici = true;
            }
            return contorL;
        }

        public int Right()
        {
            char[] sirCaractere = this.sir.ToCharArray();
            bool toateMaiMici = true;

            for (int i = 1; i < sirCaractere.Length - 1; i++)
            {
                for (int j = i+1; j < sirCaractere.Length; j++)
                {
                    if (sirCaractere[j] > sirCaractere[i])
                    {
                        toateMaiMici = false;
                        break;
                    }
                }
                if (toateMaiMici)
                {
                    contorR++;
                }
                toateMaiMici = true;
            }
            return contorR;
        }

        public void numereLR()
        {
           if(contorL >= contorR)
            {
                Console.WriteLine(contorR);
            }
           else 
            {
                Console.WriteLine(contorL);
            }
        }
    }
}
