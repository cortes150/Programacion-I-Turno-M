using System;

class Program
{
    static void Main()
    {
        double TotalKm = 0;
        double kilometros;

        Console.Write("Ingrese kilómetros: ");
        kilometros = Convert.ToDouble(Console.ReadLine());

        while (kilometros != 0)
        {
            TotalKm = TotalKm + kilometros;

            Console.Write("Ingrese kilómetros: ");
            kilometros = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Total Km: " + TotalKm);
    }
}