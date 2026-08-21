namespace PracticaProgramacionII;

class Ejercicio30
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 30");
        Console.WriteLine("================================");

        Console.Write("Ingrese el color del semáforo: ");
        string color = Console.ReadLine();

        if (color == "rojo")
        {
            Console.WriteLine("Detenerse");
        }
        else if (color == "amarillo")
        {
            Console.WriteLine("Precaución");
        }
        else if (color == "verde")
        {
            Console.WriteLine("Avanzar");
        }
        else
        {
            Console.WriteLine("Color no válido");
        }

        Console.WriteLine("================================");
    }
}