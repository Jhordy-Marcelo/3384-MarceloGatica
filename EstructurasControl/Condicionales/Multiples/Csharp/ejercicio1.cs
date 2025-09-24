using System;

class ProgramaCondicionalMultiple1
{
    static void Main()
    {
        Console.Write("Ingresa tu nota (0 - 20): ");
        int nota = Convert.ToInt32(Console.ReadLine());

        // Condicional múltiple
        if (nota >= 18)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 14)
        {
            Console.WriteLine("Bueno");
        }
        else if (nota >= 11)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Deficiente");
        }
    }
}
