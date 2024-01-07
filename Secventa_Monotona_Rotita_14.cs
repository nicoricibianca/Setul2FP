using System;

class Program
{
    static bool SecventaMonotonaRotita(int[] secventa)
    {
        //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
        //Determinati daca o secventa de n numere este o secventa monotona rotita.
        int n = secventa.Length;

        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (secventa[i] < secventa[minIndex])
            {
                minIndex = i;
            }
        }

        bool esteMonotona = true;
        bool crescatoare = true;
        bool descrescatoare = true;

        for (int i = 0; i < n - 1; i++)
        {
            if (secventa[(minIndex + i) % n] > secventa[(minIndex + i + 1) % n])
            {
                crescatoare = false;
            }

            if (secventa[(minIndex + i) % n] < secventa[(minIndex + i + 1) % n])
            {
                descrescatoare = false;
            }
        }

        esteMonotona = crescatoare || descrescatoare;

        return esteMonotona;
    }

    static void Main()
    {
        int[] secventa = { 4, 3, 2, 1, 5, 6, 7 }; 

        bool esteMonotonaRotita = SecventaMonotonaRotita(secventa);

        if (esteMonotonaRotita)
        {
            Console.WriteLine("Secventa este rotita monotona");
        }
        else
        {
            Console.WriteLine("Secventa nu este rotita monotona.");
        }
    }
}
