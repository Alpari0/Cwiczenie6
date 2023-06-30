using System;

    int[,] tab = new int[10, 10];
    int licznik = 1;
    int n = 10;
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            tab[i, j] = licznik;
            licznik++;
        }
        for (int j = i + 1; j < n - i; j++)
        {
            tab[j, n - i - 1] = licznik;
            licznik++;
        }
        for (int j = n - i - 2; j >= i; j--)
        {
            tab[n - i - 1, j] = licznik;
            licznik++;
        }
        for (int j = n - i - 2; j > i; j--)
        {
            tab[j, i] = licznik;
            licznik++;
        }
    }

    if (n % 2 == 1)
    {
        tab[n / 2, n / 2] = licznik;
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(tab[i, j] + " ");
        }
        Console.WriteLine();
    }
