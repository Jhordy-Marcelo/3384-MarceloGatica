using System;

class ProgramaCondicionalMultiple2
{
    static void Main()
    {
        Console.WriteLine("=== Menú de Opciones ===");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Elige una opción (1-4): ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        // Condicional múltiple
        if (opcion == 1)
        {
            Console.WriteLine("Elegiste: Sumar");
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Elegiste: Restar");
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Elegiste: Multiplicar");
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Elegiste: Dividir");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
}
