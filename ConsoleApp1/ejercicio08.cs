namespace PracticaProgramacionII;

class Ejercicio08
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 08");
        Console.WriteLine("================================");

        Console.Write("Ingrese la temperatura en Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperatura en Fahrenheit: " + fahrenheit);

        Console.WriteLine("================================");
    }
}