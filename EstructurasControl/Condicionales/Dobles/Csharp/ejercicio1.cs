using System;

class ProgramaCondicionalDoble1
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Condicional doble
        if (numero >= 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else
        {
            Console.WriteLine("El número es negativo.");
        }
    }
}
