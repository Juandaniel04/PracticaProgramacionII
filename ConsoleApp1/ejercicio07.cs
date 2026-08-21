namespace PracticaProgramacionII;

class Ejercicio07
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 07");
        Console.WriteLine("================================");

        Console.Write("Ingrese el valor de a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Antes del intercambio:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        int temporal = a;
        a = b;
        b = temporal;

        Console.WriteLine("Después del intercambio:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("================================");
    }
}