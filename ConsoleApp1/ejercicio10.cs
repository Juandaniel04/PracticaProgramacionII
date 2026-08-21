namespace PracticaProgramacionII;

class Ejercicio10
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 10");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int residuo = numero1 % numero2;

        Console.WriteLine("El residuo es: " + residuo);

        Console.WriteLine("================================");
    }
}
