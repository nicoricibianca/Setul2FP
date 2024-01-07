using System;

namespace Setul2Ex7
{
    internal class Program
    {
        static void MicMare(int[] numere)
        {
            int mic = numere[0];
            int mare = numere[0];
            for (int i = 1; i < numere.Length; i++)
            {
                if (numere[i] < mic)
                {
                    mic = numere[i];
                }

                else if (numere[i] > mare)
                {
                    mare = numere[i];
                }
            }
            Console.WriteLine($"Numarul cel mai mic este {mic}.");
            Console.WriteLine($"Numarul cel mai mare este {mare}.");
        }
        
        
        static void Main(string[] args)
        {
            //Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa.
            int[] secventa = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            MicMare(secventa);

        }
    }
}