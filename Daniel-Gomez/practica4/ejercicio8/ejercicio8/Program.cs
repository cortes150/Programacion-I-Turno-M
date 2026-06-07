using System;

class Program
{
    static void Main()
    {
        int TotalCanciones = 0;
        string nombre;

        Console.Write("Ingrese nombre de canción: ");
        nombre = Console.ReadLine();

        while (nombre != "fin")
        {
            TotalCanciones++;

            Console.Write("Ingrese nombre de canción: ");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("Total Canciones: " + TotalCanciones);
    }
}