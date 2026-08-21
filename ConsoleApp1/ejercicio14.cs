namespace PracticaProgramacionII;

class Ejercicio14
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 14");
        Console.WriteLine("================================");

        Console.Write("Ingrese un número: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("El número es positivo");
        }
        else
        {
            Console.WriteLine("El número es negativo");
        }

        Console.WriteLine("================================");
    }
}