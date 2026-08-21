namespace PracticaProgramacionII;

class Ejercicio26
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 26");
        Console.WriteLine("================================");

        Console.Write("Ingrese un número del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());

        if (dia == 1)
        {
            Console.WriteLine("Lunes");
        }
        else if (dia == 2)
        {
            Console.WriteLine("Martes");
        }
        else if (dia == 3)
        {
            Console.WriteLine("Miércoles");
        }
        else if (dia == 4)
        {
            Console.WriteLine("Jueves");
        }
        else if (dia == 5)
        {
            Console.WriteLine("Viernes");
        }
        else if (dia == 6)
        {
            Console.WriteLine("Sábado");
        }
        else if (dia == 7)
        {
            Console.WriteLine("Domingo");
        }
        else
        {
            Console.WriteLine("Error: número no válido");
        }

        Console.WriteLine("================================");
    }
}
