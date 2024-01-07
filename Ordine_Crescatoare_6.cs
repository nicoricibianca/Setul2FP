using System;

namespace Setul2Ex6
{
    internal class Program
    {
       static bool Crescatoare(int[] numere)
        {
            for (int i = 0; i < numere.Length - 1; i++)
            {
                if (numere[i] > numere[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
      
        
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
            int[] secventa = { 0, 1, 2, 3, 4, 5 };
            bool esteCrescatoare = Crescatoare(secventa);

            if (esteCrescatoare)
            {
                Console.WriteLine("Secventa este crescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa este descrescatoare.");
            }
        }
    }
}