using System;

namespace Setul2Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
            int[] secventa = { 1, 2, 3, 4, 5, 5, 6, 7, 7 };
            int maxim = NrMaxim(secventa);
            Console.WriteLine($"Numarul maxim de numere consecutive egale este {maxim}.");
            
        }

        static int NrMaxim(int[] numere)
        {
            if (numere.Length == 0)
            {
                return 0;
            }
            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numere.Length; i++)
            {
                if (numere[i] == numere[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }
    }
}