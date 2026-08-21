namespace PracticaProgramacionII;

class Ejercicio03
{
    public static void Ejecutar()
    {
        const int ANIO_ACTUAL = 2026;

        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 03");
        Console.WriteLine("================================");

        Console.Write("Ingrese su año de nacimiento: ");
        int anioNacimiento = int.Parse(Console.ReadLine());

        int edad = ANIO_ACTUAL - anioNacimiento;

        Console.WriteLine("Su edad aproximada es: " + edad + " años");

        Console.WriteLine("================================");
    }
}