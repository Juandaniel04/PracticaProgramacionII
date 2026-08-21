namespace PracticaProgramacionII;

class Ejercicio16
{
    public static void Ejecutar()
    {
        const string CLAVE_CORRECTA = "1234";

        Console.WriteLine("================================");
        Console.WriteLine("       EJERCICIO 16");
        Console.WriteLine("================================");

        Console.Write("Ingrese la contraseña: ");
        string clave = Console.ReadLine();

        if (clave == CLAVE_CORRECTA)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }

        Console.WriteLine("================================");
    }
}