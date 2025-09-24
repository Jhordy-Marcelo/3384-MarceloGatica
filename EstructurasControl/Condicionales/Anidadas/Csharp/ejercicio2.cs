using System;

class ProgramaAnidado2
{
    static void Main()
    {
        Console.Write("Ingresa tu nota (0 - 20): ");
        int nota = Convert.ToInt32(Console.ReadLine());

        // Condicional anidada
        if (nota >= 0 && nota <= 20)
        {
            if (nota >= 11)
            {
                Console.WriteLine("¡Aprobaste el curso!");
            }
            else
            {
                Console.WriteLine("Desaprobaste el curso.");
            }
        }
        else
        {
            Console.WriteLine("La nota ingresada no es válida.");
        }
    }
}
