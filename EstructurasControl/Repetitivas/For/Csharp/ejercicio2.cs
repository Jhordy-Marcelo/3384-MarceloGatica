using System;

class RepetitivaFor2
{
    static void Main()
    {
        Console.WriteLine("=== Suma de los primeros 5 números ===");

        int suma = 0;

        // Bucle for
        for (int i = 1; i <= 5; i++)
        {
            suma += i;  // equivalente a suma = suma + i
        }

        Console.WriteLine($"La suma es: {suma}");
    }
}
