using System;

class Program
{
    static void Main()
    {
        int TotalPlatos = 0;
        string nombre;

        Console.Write("Ingrese nombre del plato: ");
        nombre = Console.ReadLine();

        while (nombre != "cerrar")
        {
            TotalPlatos++;

            Console.Write("Ingrese nombre del plato: ");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("Total Platos: " + TotalPlatos);
    }
}