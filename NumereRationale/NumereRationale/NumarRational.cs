using System;
using System.Collections.Generic;
using System.Text;

namespace NumereRationale
{
    class NumarRational
    {
        public int numitor = 1;
        public int numarator = 1;
        public string fractie;

        public NumarRational()
        {
            fractie = numarator + "/" + numitor;
        }

        public NumarRational(int numarator)
        {
            this.numarator = numarator;
            fractie = numarator + "/" + numitor;
        }

        public NumarRational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
            fractie = numarator + "/" + numitor;
        }

        public static int Cmmdc(int numitor1, int numitor2)
        {
            int nr1 = numitor1, nr2 = numitor2;
            while (nr1 != nr2)
                if (nr1 > nr2)
                    nr1 -= nr2;
                else
                    nr2 -= nr1;

            return nr1;
        }

        public static int Cmmmc(int numitor1, int numitor2)
        {
            int n = numitor1, k = numitor2, p, cmmmc;
            p = n * k;
            while (n != k)
            {
                if (n > k)
                    n = n - k;
                else
                    k = k - n;
            }
            cmmmc = p / k;
            return cmmmc;
        }

        public static NumarRational operator +(NumarRational numarNumarRational, NumarRational numar2NumarRational)
        {
            if (numarNumarRational.numitor == numar2NumarRational.numitor)
            {
                return (new NumarRational(numarNumarRational.numarator + numar2NumarRational.numarator, numarNumarRational.numitor));
            }
            else
            {
                if (numarNumarRational.numitor > numar2NumarRational.numitor)
                {
                    numar2NumarRational = numar2NumarRational * Cmmmc(numarNumarRational.numitor, numar2NumarRational.numitor);
                    return (new NumarRational(numarNumarRational.numarator + numar2NumarRational.numarator, numarNumarRational.numitor));
                }
                else
                {
                    numarNumarRational = numarNumarRational * Cmmmc(numarNumarRational.numitor, numar2NumarRational.numitor);
                    return (new NumarRational(numarNumarRational.numarator + numar2NumarRational.numarator, numarNumarRational.numitor));
                }
            }
        }

        public static NumarRational operator -(NumarRational numarNumarRational, NumarRational numar2NumarRational)
        {
            if (numarNumarRational.numitor == numar2NumarRational.numitor)
            {
                return (new NumarRational(numarNumarRational.numarator - numar2NumarRational.numarator, numarNumarRational.numitor));
            }
            else
            {
                if (numarNumarRational.numitor > numar2NumarRational.numitor)
                {
                    numar2NumarRational = numar2NumarRational * Cmmmc(numarNumarRational.numitor, numar2NumarRational.numitor);
                    return (new NumarRational(numarNumarRational.numarator - numar2NumarRational.numarator, numarNumarRational.numitor));
                }
                else
                {
                    numarNumarRational = numarNumarRational * Cmmmc(numarNumarRational.numitor, numar2NumarRational.numitor);
                    return (new NumarRational(numarNumarRational.numarator - numar2NumarRational.numarator, numarNumarRational.numitor));
                }
            }
        }

        public static NumarRational operator *(NumarRational numarNumarRational, NumarRational numar2NumarRational)
        {
            return (new NumarRational(numarNumarRational.numarator * numar2NumarRational.numitor, numarNumarRational.numitor * numar2NumarRational.numarator));
        }

        public static NumarRational operator *(NumarRational numarNumarRational, int numar2NumarRational)
        {
            return (new NumarRational(numarNumarRational.numarator * numar2NumarRational, numarNumarRational.numitor));
        }

        public static NumarRational operator /(NumarRational numarNumarRational, NumarRational numar2NumarRational)
        {
            return (new NumarRational(numarNumarRational.numarator * numar2NumarRational.numarator, numar2NumarRational.numitor * numarNumarRational.numitor));
        }

        public static NumarRational operator ^(NumarRational numarNumarRational, int putere)
        {
            return (new NumarRational(Convert.ToInt32(Math.Pow(numarNumarRational.numarator, putere)), Convert.ToInt32(Math.Pow(numarNumarRational.numitor, putere))));
        }

        public static string FormaIreductibila(NumarRational numarNumarRational)
        {
            int simplificator = Cmmdc(numarNumarRational.numarator, numarNumarRational.numitor);

            do
            {
                numarNumarRational.numitor = numarNumarRational.numitor / simplificator;
                numarNumarRational.numarator = numarNumarRational.numarator / simplificator;
            } while (numarNumarRational.numitor / simplificator == 0 && numarNumarRational.numarator / simplificator == 0);
            string numarNumarRationalIreductibil = numarNumarRational.numarator + " / " + numarNumarRational.numitor;
            return numarNumarRationalIreductibil;
        }
    }
}
