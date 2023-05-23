int val = 9;
int hval = val;
int xval = val;

for (int a = 1; a <= val; a++) {
    for (int x = val; x >= 1; x--)
    {

        if (x == hval)
        {
            if (x % 2 == 0)
            {
                Console.Write("  ");
                Console.Write("*");
            }

            else
            {
                Console.Write("  ");
                Console.Write(x);
            }
        }
        else
        {
            Console.Write("  ");
        }

    }

    for (int x = 2; x <= val; x++)
    {
        if (x == hval)
        {
            if (x % 2 == 0)
            {
                Console.Write("  ");
                Console.Write("*");
            }

            else
            {
                Console.Write("  ");
                Console.Write(x);
            }
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine("");
    hval--;
}

//reverse
for (int a = 2; a <= val; a++)
{
    for (int x = 2; x <= val; x++)
    {

        if (x == xval)
        {
            if (a % 2 == 0)
            {
                Console.Write("  ");
                Console.Write("*");
            }

            else
            {
                Console.Write("  ");
                Console.Write(a);
            }
        }
        else
        {
            Console.Write("  ");
        }

    }

    for (int x = val; x >= 2; x--)
    {
        if (x == xval)
        {
            if (a % 2 == 0)
            {
                Console.Write("  ");
                Console.Write("*");
            }

            else
            {
                Console.Write("  ");
                Console.Write(a);
            }
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine("");
    xval--;
}

Console.ReadLine();