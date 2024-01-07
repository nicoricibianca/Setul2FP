using System;

namespace Setul2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
            int[] numere = { -2, -1, 0, 1, 2, 3, 4, 5, };
            int negative = 0;
            int pozitive = 0;
            int zero = 0;

            foreach (int num in numere)
            {
                if (num < 0)
                {
                    negative++;
                }
                else if (num == 0)
                {
                    zero++;
                }
                else
                {
                    pozitive++;
                }
            }
            Console.WriteLine($"Exista {negative} numere negative, {pozitive} numere pozitive si {zero} de zero.");
        }
    }
}