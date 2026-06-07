using System;

class Program
{
    static void Main()
    {
        int puntaje;
        int maxPuntaje = int.MinValue;

        Console.Write("Ingrese puntaje (-1 para terminar): ");
        puntaje = Convert.ToInt32(Console.ReadLine());

        while (puntaje != -1)
        {
            if (puntaje > maxPuntaje)
            {
                maxPuntaje = puntaje;
            }

            Console.Write("Ingrese puntaje (-1 para terminar): ");
            puntaje = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Puntaje máximo: " + maxPuntaje);
    }
}