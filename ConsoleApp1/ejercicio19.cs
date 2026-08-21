namespace PracticaProgramacionII;

class Ejercicio19
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 19");
        Console.WriteLine("================================");

        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 % numero2 == 0)
        {
            Console.WriteLine("El primer número es divisible entre el segundo");
        }
        else
        {
            Console.WriteLine("El primer número no es divisible entre el segundo");
        }

        Console.WriteLine("================================");
    }
}
