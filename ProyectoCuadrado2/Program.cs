class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese los cuatro números
        Console.WriteLine("Ingrese cuatro números:");

        Console.Write("Número 1: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Número 2: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Número 3: ");
        double num3 = double.Parse(Console.ReadLine());

        Console.Write("Número 4: ");
        double num4 = double.Parse(Console.ReadLine());

        // Calcular la suma de los dos primeros números
        double suma = num1 + num2;

        // Calcular el producto del tercero y el cuarto número
        double producto = num3 * num4;

        // Mostrar los resultados por pantalla
        Console.WriteLine("La suma de los dos primeros números es: " + suma);
        Console.WriteLine("El producto del tercer y cuarto número es: " + producto);

        // Esperar a que el usuario presione una tecla para cerrar la aplicación
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
