namespace PracticaProgramacionII;

class Ejercicio20
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 20");
        Console.WriteLine("================================");

        Console.Write("Ingrese las horas trabajadas en la semana: ");
        int horas = int.Parse(Console.ReadLine());

        if (horas > 40)
        {
            Console.WriteLine("Tiene horas extra");
        }
        else
        {
            Console.WriteLine("Jornada normal");
        }

        Console.WriteLine("================================");
    }
}