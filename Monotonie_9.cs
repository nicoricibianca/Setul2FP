using System;

namespace Setul2Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine daca o secventa de n numere este monotona.
            //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
            int[] secventa = { 1, 2, 3, 4, 5, 6};
            bool monotona = Monotona(secventa);
            if (monotona)
            {
                Console.WriteLine("Secventa este monotona.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona.");
            }

        }

        public static bool Monotona(int[] secventa)
        {
            bool crescatoare = true;
            bool descrescatoare = true;
            for (int i = 1; i <= secventa.Length; i++)
            {
                if (secventa[i] < secventa[i - 1])
                {
                    crescatoare = false;
                }
                if (secventa[i] > secventa[i - 1])
                {
                    descrescatoare = false;
                }
            }
            return crescatoare || descrescatoare;
        }
    }
}