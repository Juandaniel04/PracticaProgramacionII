namespace PracticaProgramacionII;

class Ejercicio09
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 09");
        Console.WriteLine("================================");

        Console.Write("Ingrese la cantidad de minutos: ");
        int minutosTotales = int.Parse(Console.ReadLine());

        int horas = minutosTotales / 60;
        int minutos = minutosTotales % 60;

        Console.WriteLine("Horas: " + horas);
        Console.WriteLine("Minutos: " + minutos);

        Console.WriteLine("================================");
    }
}
