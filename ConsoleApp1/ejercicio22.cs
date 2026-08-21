namespace PracticaProgramacionII;

class Ejercicio22
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 22");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int numero3 = int.Parse(Console.ReadLine());

        if (numero1 > numero2 && numero1 > numero3)
        {
            Console.WriteLine("El primer número es el mayor");
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            Console.WriteLine("El segundo número es el mayor");
        }
        else
        {
            Console.WriteLine("El tercer número es el mayor");
        }

        Console.WriteLine("================================");
    }
}