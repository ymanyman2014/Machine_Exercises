// See https://aka.ms/new-console-template for more information

int val = 5;
int i, j, k;
for (i = 1; i <= val; i++)
{
    for (j = 1; j <= val - i; j++)
    {
        // Console.Write("");  
    }

    for (k = 1; k <= i; k++)
    {
        int a = i*k;

        if (a < 10)
        {
            Console.Write("   ");
            Console.Write(a);
        }
        else {
            Console.Write("  ");
            Console.Write(a);
        }
        

    }
    Console.WriteLine(" ");
}

for (i = val-1; i >= 1; i--)
{
    for (j = 1; j <= val - i; j++)
    {
        // Console.Write("");  
    }

    for (k = 1; k <= i; k++)
    {
        int a = i * k;

        if (a < 10)
        {
            Console.Write("   ");
            Console.Write(a);
        }
        else
        {
            Console.Write("  ");
            Console.Write(a);
        }


    }
    Console.WriteLine(" ");
}
Console.ReadLine();
