using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        string nombre;

        Console.Write("Ingrese nombre: ");
        nombre = Console.ReadLine();

        while (nombre != "FIN")
        {
            contador++;

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("Cantidad de estudiantes: " + contador);
    }
}