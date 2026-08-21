namespace PracticaProgramacionII;

class Ejercicio04
{
    public static void Ejecutar()
    {
        const double IVA = 0.13;

        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 04");
        Console.WriteLine("================================");

        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        double iva = precio * IVA;
        double precioFinal = precio + iva;

        Console.WriteLine("IVA: " + iva);
        Console.WriteLine("Precio final: " + precioFinal);

        Console.WriteLine("================================");
    }
}