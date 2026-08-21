namespace PracticaProgramacionII;

class Ejercicio23
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 23");
        Console.WriteLine("================================");

        Console.Write("Ingrese la nota: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 90)
        {
            Console.WriteLine("Nota: A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Nota: B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Nota: C");
        }
        else if (nota >= 60)
        {
            Console.WriteLine("Nota: D");
        }
        else
        {
            Console.WriteLine("Nota: F");
        }

        Console.WriteLine("================================");
    }
}
