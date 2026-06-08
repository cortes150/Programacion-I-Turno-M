using System;

class Program
{
    static void Main()
    {
        double tiempoA, tiempoB;
        int penalA, penalB;

        Console.Write("Tiempo Robot A: ");
        tiempoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Penalizaciones Robot A: ");
        penalA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tiempo Robot B: ");
        tiempoB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Penalizaciones Robot B: ");
        penalB = Convert.ToInt32(Console.ReadLine());

        if (tiempoA < tiempoB && penalA <= penalB)
            Console.WriteLine("Gana Robot A");
        else
            Console.WriteLine("Gana Robot B");
    }
}