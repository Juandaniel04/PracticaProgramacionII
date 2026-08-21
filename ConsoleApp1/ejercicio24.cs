namespace PracticaProgramacionII;

class Ejercicio24
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 24");
        Console.WriteLine("================================");

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 0 && edad <= 12)
        {
            Console.WriteLine("Niño");
        }
        else if (edad >= 13 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 64)
        {
            Console.WriteLine("Adulto");
        }
        else if (edad >= 65)
        {
            Console.WriteLine("Adulto mayor");
        }
        else
        {
            Console.WriteLine("Edad no válida");
        }

        Console.WriteLine("================================");
    }
}