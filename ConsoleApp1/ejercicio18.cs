namespace PracticaProgramacionII;

class Ejercicio18
{
    public static void Ejecutar()
    {
        const double DESCUENTO = 0.10;

        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 18");
        Console.WriteLine("================================");

        Console.Write("Ingrese el monto de la compra: ");
        double compra = double.Parse(Console.ReadLine());

        if (compra > 100)
        {
            double descuento = compra * DESCUENTO;
            double precioFinal = compra - descuento;

            Console.WriteLine("Se aplicó un descuento del 10%");
            Console.WriteLine("Precio final: " + precioFinal);
        }
        else
        {
            Console.WriteLine("No se aplica descuento");
            Console.WriteLine("Precio original: " + compra);
        }

        Console.WriteLine("================================");
    }
}