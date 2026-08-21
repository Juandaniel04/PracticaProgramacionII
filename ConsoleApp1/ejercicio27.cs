namespace PracticaProgramacionII;

class Ejercicio27
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 27");
        Console.WriteLine("================================");

        Console.Write("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura en metros: ");
        double estatura = double.Parse(Console.ReadLine());

        double imc = peso / (estatura * estatura);

        Console.WriteLine("Su IMC es: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidad");
        }

        Console.WriteLine("================================");
    }
}