using System;

class ProgramaAnidado1
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Condicional anidada
        if (numero >= 0)
        {
            if (numero == 0)
            {
                Console.WriteLine("El número es cero.");
            }
            else
            {
                Console.WriteLine("El número es positivo.");
            }
        }
        else
        {
            Console.WriteLine("El número es negativo.");
        }
    }
}
