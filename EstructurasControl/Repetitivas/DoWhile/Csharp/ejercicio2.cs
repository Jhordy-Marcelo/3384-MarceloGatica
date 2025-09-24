using System;

class RepetitivaDoWhile2
{
    static void Main()
    {
        int opcion;

        // Bucle do-while
        do
        {
            Console.WriteLine("\n=== Menú Principal ===");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Despedirse");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("¡Hola! 👋");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("¡Adiós! 👋");
            }

        } while (opcion != 3);

        Console.WriteLine("Programa finalizado.");
    }
}
