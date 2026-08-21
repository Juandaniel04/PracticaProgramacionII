namespace PracticaProgramacionII;

class Ejercicio17
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 17");
        Console.WriteLine("================================");

        Console.Write("Ingrese un año: ");
        int anio = int.Parse(Console.ReadLine());

        if (anio % 4 == 0)
        {
            Console.WriteLine("El año es bisiesto");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto");
        }

        Console.WriteLine("================================");
    }
}
