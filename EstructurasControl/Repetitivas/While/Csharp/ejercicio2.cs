using System;

class RepetitivaWhile2
{
    static void Main()
    {
        Console.WriteLine("=== Suma de números (ingresa 0 para terminar) ===");

        int numero;
        int suma = 0;

        Console.Write("Ingresa un número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Bucle while
        while (numero != 0)
        {
            suma += numero;

            Console.Write("Ingresa otro número (0 para terminar): ");
            numero = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"La suma total es: {suma}");
    }
}
