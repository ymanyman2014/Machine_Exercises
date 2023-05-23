int val = 6;
for (int x = 1; x <= val; x++) {
    int b = x;
    for (int a = 1; a <= val-1; a++) {
        if (b > 10)
        {
            Console.Write("   ");
            Console.Write(b);
            b = (b * x) + b;
        }
        else if (b > 100)
        {
            Console.Write("  ");
            Console.Write(b);
            b = (b * x) + b;
        }

        else if (b > 500)
        {
            Console.Write(" ");
            Console.Write(b);
            b = (b * x) + b;
        }

        else {
            Console.Write("    ");
            Console.Write(b);
            b = (b * x) + b;
        }
    }
    Console.WriteLine("");
}
Console.ReadLine();