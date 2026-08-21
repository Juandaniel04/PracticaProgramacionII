namespace PracticaProgramacionII;

class Ejercicio21
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 21");
        Console.WriteLine("================================");

        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else
        {
            Console.WriteLine("El número es cero");
        }

        Console.WriteLine("================================");
    }
}