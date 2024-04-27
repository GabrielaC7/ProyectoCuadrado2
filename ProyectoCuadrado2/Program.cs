using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el lado del cuadrado: ");
        string input = Console.ReadLine();

        double lado;
        if (double.TryParse(input, out lado))
        {
            double perimetro = 4 * lado;

            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número válido.");
        }

        Console.WriteLine("Presiona cualquier tecla para finalizar.");
        Console.ReadKey();
    }
}
