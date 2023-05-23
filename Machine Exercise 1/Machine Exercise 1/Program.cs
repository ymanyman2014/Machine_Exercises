int row = 4;
int i, j, k;

for (int x = 1; x <= 2; x++) {
    for (i = x; i <= row; i++)
    {

        for (j = 1; j <= row - i; j++)
        {
            Console.Write(" ");
        }

        for (k = 1; k <= (2 * i - 1); k++)
        {
            if (k == 1 || k == (2 * i - 1))
                Console.Write("*");
            else
                Console.Write(" ");
        }

        Console.WriteLine("");
    }


    for (i = 1; i <= row - 1; i++)
    {

        for (j = 1; j <= i; j++)
        {
            Console.Write(" ");
        }

        for (k = 1; k <= (2 * (row - i) - 1); k++)
        {
            if (k == 1 || k == (2 * (row - i) - 1))
                Console.Write("*");
            else
                Console.Write(" ");
        }

        Console.WriteLine("");
    }
}

Console.ReadKey();