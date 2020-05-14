using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace ClasaElevi
{
    class Elev
    {
        public string NumeElev { get; set; }
        public string PrenumeElev { get; set; }
        public double MediaNote { get; set; }



        public Elev(string NumeElev, string PrenumeElev, double MediaNote )
        {
            this.NumeElev = NumeElev;
            this.PrenumeElev = PrenumeElev;
            this.MediaNote = MediaNote;
        }
    }
}
