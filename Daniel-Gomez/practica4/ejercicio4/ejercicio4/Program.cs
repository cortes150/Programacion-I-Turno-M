using System;
class Program
{
    static void Main()
    {
        int Totalcafes = 0;
        string respuestas;
        Console.Write("Compro cafe (si/no): ");
        respuestas = Console.ReadLine();
        while (respuestas != "salir")
        {
            if (respuestas == "si")
            {
                Totalcafes++;
            }
            Console.WriteLine("Compro cafes(si/salir)");
            respuestas = Console.ReadLine();
        }
        Console.WriteLine("Total cafes vendidos: " + Totalcafes);
    }
}