using System;

namespace Setul2Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare
            //sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive
            //(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
            //Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

            int[] secventa = { 4, 5, 6, 7, 1, 2, 3 };
            bool esteCrescatoareRotita = EsteCrescatoareRotita(secventa);
            if (esteCrescatoareRotita )
            {
                Console.WriteLine("Secventa este crescatoare rotita!");
            }
            else
            {
                Console.WriteLine("Secventa nu este crescatoare rotita!");
            }

        }

        static bool EsteCrescatoareRotita(int[] secventa)
        {
            int n = secventa.Length;
            int minIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (secventa[i] < secventa[minIndex])
                {
                    minIndex = i;
                }
            }
            bool esteCrescatoare = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (secventa[(minIndex + i) % n] > secventa[(minIndex + i + 1) % n])
                {
                    esteCrescatoare = false;
                    break;
                }
            }
            return esteCrescatoare;
        }
    }
}