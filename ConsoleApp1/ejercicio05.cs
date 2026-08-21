namespace PracticaProgramacionII;

class Ejercicio05
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 05");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;
        double division = numero1 / numero2;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);

        Console.WriteLine("================================");
    }
}
