namespace PracticaProgramacionII;

public class Ejercicio02
{
    public static void Ejecutar()
    {
        const double PI = 3.14159;

        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 02");
        Console.WriteLine("================================");

        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double area = PI * radio * radio;

        Console.WriteLine($"El área del círculo es: {area}");

        Console.WriteLine("================================");
    }
}