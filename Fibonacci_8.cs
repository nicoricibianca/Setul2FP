using System;

namespace Setul2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determianti al n-lea numar din sirul lui Fibonacci.
            //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
            int n = int.Parse(Console.ReadLine());
            int rezultat = Fibonaci(n);
            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {rezultat}.");
        }

        public static int Fibonaci(int n)
        {
            if (n <= 1)
                return n;
            
            return Fibonaci(n-1) + Fibonaci(n-2);
        }
    }
}