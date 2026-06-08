using System;

class Program
{
    static void Main()
    {
        int puntos = 0;
        string resultado;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Resultado partida " + i + " (V/E/D): ");
            resultado = Console.ReadLine().ToUpper();

            if (resultado == "V")
                puntos += 3;
            else if (resultado == "E")
                puntos += 1;
        }

        Console.WriteLine("Total de puntos: " + puntos);
    }
}