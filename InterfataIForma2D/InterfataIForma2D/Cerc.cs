using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataIForma2D
{
    class Cerc : IForma2D
    {
        public string Denumire { get; }
        public int Raza { get; set; }

        public Cerc(string denumire, int raza)
        {
            Denumire = denumire;
            Raza = raza;
        }

        public void Aria()
        {
            int arie;
            arie = Convert.ToInt32(Math.Pow(Raza, 2) * Math.PI);
            Console.WriteLine("Aria {0} este: {1} ", Denumire, arie);
        }

        public void LungimeaFrontierei()
        {
            int circumferinta;
            circumferinta = Convert.ToInt32(2 * Math.PI * Raza);
            Console.WriteLine("Lungimea frontierei {0} este: {1} ", Denumire, circumferinta);
        }

        public static void FormuleCerc(IForma2D forma)
        {
            forma.Aria();
            forma.LungimeaFrontierei();
        }
    }
}
