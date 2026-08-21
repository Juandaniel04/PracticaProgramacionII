namespace PracticaProgramacionII;

class Ejercicio13
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 13");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("El primer número es mayor");
        }
        else
        {
            Console.WriteLine("El segundo número es mayor");
        }

        Console.WriteLine("================================");
    }
}
