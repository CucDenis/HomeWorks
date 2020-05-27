using System;

namespace Clasa_Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiva stiva = new Stiva(5);
            Stiva stivaNoua = new Stiva(5);

            stiva.Push(5);
            stiva.Push(6);
            stiva.Push(5);
            stiva.Push(6);

            stiva.Push("informatica");
            stiva.Push("antagonist");

            stivaNoua.Push(1);
            stivaNoua.Push(2);
            stivaNoua.Push(3);
            stivaNoua.Push("macaroane");
            stivaNoua.Push("Decameronul");

            for (int i=0; i < 4; i++)
            {
                Console.WriteLine(stiva.Pop());
                Console.WriteLine(stiva.Pop("string"));
            }

            stivaNoua.Clear();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(stiva.Pop());
                Console.WriteLine(stiva.Pop("string"));
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(stivaNoua.Pop());
            }
            
        }
    }
}
