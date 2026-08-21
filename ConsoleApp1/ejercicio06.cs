namespace PracticaProgramacionII;

class Ejercicio06
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 06");
        Console.WriteLine("================================");

        Console.Write("Ingrese la primera nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio final es: " + promedio);

        Console.WriteLine("================================");
    }
}