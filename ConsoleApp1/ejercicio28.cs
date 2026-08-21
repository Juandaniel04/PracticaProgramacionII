namespace PracticaProgramacionII;

class Ejercicio28
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 28");
        Console.WriteLine("================================");

        Console.WriteLine("1. Moto");
        Console.WriteLine("2. Auto");
        Console.WriteLine("3. Autobús");
        Console.WriteLine("4. Camión");

        Console.Write("Seleccione el tipo de vehículo: ");
        int vehiculo = int.Parse(Console.ReadLine());

        if (vehiculo == 1)
        {
            Console.WriteLine("Peaje: $2");
        }
        else if (vehiculo == 2)
        {
            Console.WriteLine("Peaje: $5");
        }
        else if (vehiculo == 3)
        {
            Console.WriteLine("Peaje: $10");
        }
        else if (vehiculo == 4)
        {
            Console.WriteLine("Peaje: $15");
        }
        else
        {
            Console.WriteLine("Tipo de vehículo no válido");
        }

        Console.WriteLine("================================");
    }
}
