using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataIForma2D
{
    class Patrat:IForma2D
    {
        public string Denumire { get; }
        public int Lungime { get; set; }

        public Patrat(string denumire, int lungime)
        {
            Denumire = denumire;
            Lungime = lungime;
        }

        public void Aria()
        {
            int arie = 0;
            arie = Convert.ToInt32(Math.Pow(Lungime,2));
            Console.WriteLine("Aria {0} este: {1} ", Denumire,arie);
        }

        public void LungimeaFrontierei()
        {
            int perimetru = 0;
            perimetru = Lungime*4;
            Console.WriteLine("Lungimea frontierei {0} este: {1} ", Denumire, perimetru);
        }

        public static void FormulePatrat(IForma2D forma)
        {
            forma.Aria();
            forma.LungimeaFrontierei();
        }
    }
}
