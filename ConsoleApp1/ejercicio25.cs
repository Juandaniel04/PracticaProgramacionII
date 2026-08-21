namespace PracticaProgramacionII;

class Ejercicio25
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 25");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        Console.Write("Seleccione una operación: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Resultado: " + (numero1 + numero2));
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Resultado: " + (numero1 - numero2));
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Resultado: " + (numero1 * numero2));
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Resultado: " + (numero1 / numero2));
        }
        else
        {
            Console.WriteLine("Opción no válida");
        }

        Console.WriteLine("================================");
    }
}