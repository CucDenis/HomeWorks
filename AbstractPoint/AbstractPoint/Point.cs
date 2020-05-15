using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPoint
{
    class Point : AbstractPoint
    {
        private double r = 0;
        private double A = 0;

        public override double CoordonataRadiala { get; set; }
        public override double CoordonataUnghiulara { get; set; }
        public override double CoordonataAbcisa { get; set; }
        public override double CoordonataOrdonata { get; set; }

        public Point(string tipReprezentare, double rORx, double AorY)
        {
            if(tipReprezentare == PointRepresentation.Rectangular.ToString())
            {
                CoordonataAbcisa = rORx;
                CoordonataOrdonata = AorY;
                CoordonataRadiala = AbstractPoint.CoordonatePolareRaza(rORx,AorY);
                CoordonataUnghiulara = AbstractPoint.CoordonatePolareUnghi(rORx, AorY);
            }
            else if(tipReprezentare == PointRepresentation.Polar.ToString())
            {
                CoordonataRadiala = rORx;
                CoordonataUnghiulara = AorY;
                CoordonataAbcisa = AbstractPoint.CoordonateCartezianaX(rORx, AorY);
                CoordonataOrdonata = AbstractPoint.CoordonateCartezianaY(rORx, AorY);
            }
        }
    }
}
