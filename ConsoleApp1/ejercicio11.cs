namespace PracticaProgramacionII;

class Ejercicio11
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 11");
        Console.WriteLine("================================");

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }

        Console.WriteLine("================================");
    }
}