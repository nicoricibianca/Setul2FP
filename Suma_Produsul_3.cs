using System;

namespace Setul2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n. 
            Console.Write("Dati o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            long produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            for (int i = 1; i <= n; i++)
            {
                produs *= i;
            }
            Console.WriteLine($"Produsul este {produs} si suma este {suma}.");

        }
    }
}