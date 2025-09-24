using System;

class ProgramaCondicional2
{
    static void Main()
    {
        Console.Write("Ingresa tu nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        // Condicional simple
        if (nota >= 11)
        {
            Console.WriteLine("¡Aprobaste el curso!");
        }
    }
}
