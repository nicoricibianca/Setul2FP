using System;

namespace Setul2Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
            //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
            //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
            int[] secventa = { 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 };
            int countGrupe = NumarulDeGrupuriConsecutive(secventa);
            Console.WriteLine($"Numarul de grupuri este: {countGrupe}." );

        }

        static int NumarulDeGrupuriConsecutive(int[] secventa)
        {
            int count = 0;
            bool inGrup = false;

            foreach (int num in secventa) 
            {
                if (num != 0)
                {
                    if (!inGrup)
                    {
                        inGrup = true;
                        count++;
                    }
                }
                else
                {
                    if (inGrup)
                    {
                        inGrup = false;
                    }
                }
            }
            return count;
        }
    }
}