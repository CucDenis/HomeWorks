using System;

namespace NumereRationale
{
    class Program
    {
        static void Main(string[] args)
        {
            NumarRational fractie = new NumarRational(24,46);
            NumarRational fractie1 = new NumarRational(29, 146);
            Console.WriteLine((fractie/fractie1).fractie);
        }
    }
}
