using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPoint
{
    abstract class AbstractPoint
    {
        public enum PointRepresentation
        {
            Polar,
            Rectangular
        }

        abstract public double CoordonataRadiala { get; set; }
        abstract public double CoordonataUnghiulara { get; set; }
        abstract public double CoordonataAbcisa { get; set; }
        abstract public double CoordonataOrdonata { get; set; }


        public void Move(double dx, double dy)
        {
            CoordonataAbcisa = dx;
            CoordonataOrdonata = dy;
        }

        public void Rotate(double angle)
        {
            CoordonataUnghiulara += angle;
        }

        public override string ToString()
        {

            return "("+CoordonataAbcisa+", "+CoordonataOrdonata+")"+":"+"["+CoordonataRadiala+", "+CoordonataUnghiulara+"]";
        }

        protected static double CoordonatePolareRaza(double x, double y)
        {
            double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return r;
        }

        protected static double CoordonatePolareUnghi(double x, double y)
        {
            double A = Math.Atan(x / y);
            return A;
        }

        protected static double CoordonateCartezianaX(double r, double A)
        {
            double x = r*Math.Cos(A);
            return x;
        }

        protected static double CoordonateCartezianaY(double r, double A)
        {
            double y = r * Math.Sin(A);
            return y;
        }
    }
}
