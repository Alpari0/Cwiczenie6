using System;

    int tab = new int[10, 10];
    int licznik = 1;
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < 10; j++)
            {
                tab[i, j] = licznik;
                licznik++;
            }
        }
        else
        {
            for (int j = 9; j >= 0; j--)
            {
                tab[i, j] = licznik;
                licznik++;
            }
        }
    }

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write(tab[i, j] + " ");
        }
        Console.WriteLine();
    }
