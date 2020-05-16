using System;

namespace AbstractPoint
{
    class Program
    {
        static void Main(string[] args)
        {
             var punct1 = new Point("Rectangular",34,60);
            var punct2 = new Point("Polar",30,60);

            Console.WriteLine(punct1.ToString());
            Console.WriteLine(punct2.ToString());

            punct2.Move(50,67);
            punct2.Rotate(60);

            Console.WriteLine(punct1.ToString());
            Console.WriteLine(punct2.ToString());
        }
    }
}
