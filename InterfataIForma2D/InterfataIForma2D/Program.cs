using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfataIForma2D
{
    class Program
    {
        static void Main(string[] args)
        {
            var patrat = new Patrat("PatratelVesel", 6);
            Patrat.FormulePatrat(patrat);

            var cerc = new Cerc("CerculInfinitului", 8);
            Cerc.FormuleCerc(cerc);
        }
    }
}
