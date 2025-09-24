using System;

class ProgramaCondicionalDoble2
{
    static void Main()
    {
        Console.Write("Ingresa tu nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        // Condicional doble
        if (nota >= 11)
        {
            Console.WriteLine("¡Aprobaste el curso!");
        }
        else
        {
            Console.WriteLine("Desaprobaste el curso.");
        }
    }
}
