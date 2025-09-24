using System;

class ProgramaRectangulo
{
    static void Main()
    {
        Console.WriteLine("=== Cálculo de Área y Perímetro de un Rectángulo ===");

        Console.Write("Ingresa la base: ");
        double baseRect = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double area = baseRect * altura;
        double perimetro = 2 * (baseRect + altura);

        Console.WriteLine($"\nEl área es: {area}");
        Console.WriteLine($"El perímetro es: {perimetro}");
    }
}
