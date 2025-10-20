namespace Ejercicios;

class EjercicioVariables
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduce tu nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Introduce tu edad");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce tu ciudad");
        string ciudad = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + ", tienes " + edad + " y vives en " + ciudad);
    }
}
