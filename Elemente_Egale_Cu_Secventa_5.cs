using System;

namespace Setul2Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
            //Se considera ca primul element din secventa este pe pozitia 0. 
            int[] numere = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int egale = ElementeEgaleCuPozitia(numere);
            Console.WriteLine($"Numarul de elemente egale cu pozitia este {egale}.");
        }
        static int ElementeEgaleCuPozitia(int[] secventa)
        {
            int count = 0;
            for (int i = 0; i < secventa.Length; i++)
            {
                if (secventa[i] == i)
                {
                    count++;
                }
            }
            return count;
        }
    }
}