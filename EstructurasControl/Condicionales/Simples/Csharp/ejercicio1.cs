using System;

class ProgramaCondicional1
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Condicional simple
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
    }
}
