namespace PracticaProgramacionII;

class Ejercicio15
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 15");
        Console.WriteLine("================================");

        Console.Write("Ingrese la nota final: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 51)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }

        Console.WriteLine("================================");
    }
}
