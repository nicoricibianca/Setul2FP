using System;

namespace Setul2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
            int[] numere = { 1, 2, 3, 8, 45, 33, 6 };
            int pare = 0;

            foreach (int num in numere)
            {
                if (num % 2 == 0)
                {
                    pare++;
                }
            }
            Console.WriteLine($"Exista {pare} numere pare.");
        }
    }
}