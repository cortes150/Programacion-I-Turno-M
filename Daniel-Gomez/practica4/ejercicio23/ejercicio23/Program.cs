using System;

class Program
{
    static void Main()
    {
        string jugador;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ronda " + i + ": ");
            jugador = Console.ReadLine();

            Console.WriteLine("Jugada registrada");
        }
    }
}