using System;

class ProgramaTiempo
{
    static void Main()
    {
        Console.WriteLine("=== Conversión de Minutos a Horas y Minutos ===");

        Console.Write("Ingresa la cantidad de minutos: ");
        int minutos = Convert.ToInt32(Console.ReadLine());

        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;

        Console.WriteLine($"\nEquivale a: {horas} horas y {minutosRestantes} minutos");
    }
}
