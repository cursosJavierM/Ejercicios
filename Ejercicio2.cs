namespace Ejercicios;

class EjercicioOperaciones
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduce un número:");
        int numeroPrimero = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce otro número:");
        int numeroSegundo = int.Parse(Console.ReadLine());

        int suma = numeroPrimero + numeroSegundo;
        Console.WriteLine("Suma es: " + suma);

        int resta = numeroPrimero - numeroSegundo;
        Console.WriteLine("Resta es: " + resta);

        int multiplicacion = numeroPrimero * numeroSegundo;
        Console.WriteLine("Multiplicación es: " + multiplicacion);

        int division = numeroPrimero / numeroSegundo;
        Console.WriteLine("División es: " + division);

        int modulo = numeroPrimero % numeroSegundo;
        Console.WriteLine("Resto de división entera es: " + modulo);


    }




    /* Pseudocódigo:
        ¿Como pido dos números?

        MOSTRAR | ESCRIBIR por pantalla: "numero"
        LEER numeroPrimero
        MOSTRAR segundo mensaje
        LEER numeroSegundo

        ... operaciones matemáticas ...
    numeroPrimero + 

    */
}