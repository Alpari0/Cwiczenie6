using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę dodatnią.");
                Console.Write("Podaj rozmiar tablicy: ");
            }

            int[,] tab = new int[n, n];
            int licznik = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tab[i, j] = licznik;
                        licznik++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        tab[i, j] = licznik;
                        licznik++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }