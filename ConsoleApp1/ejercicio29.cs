namespace PracticaProgramacionII;

class Ejercicio29
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 29");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Triángulo Equilátero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("Triángulo Isósceles");
        }
        else
        {
            Console.WriteLine("Triángulo Escaleno");
        }

        Console.WriteLine("================================");
    }
}