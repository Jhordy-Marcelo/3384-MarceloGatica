using System;

class RepetitivaDoWhile1
{
    static void Main()
    {
        Console.WriteLine("=== Contar del 1 al 5 ===");

        int i = 1;

        // Bucle do-while
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 5);
    }
}
