using System;

class Program
{
    static void Main()
    {
        double kwh, total;

        Console.Write("Consumo kWh: ");
        kwh = Convert.ToDouble(Console.ReadLine());

        if (kwh <= 100)
            total = kwh * 0.50;
        else if (kwh <= 200)
            total = (100 * 0.50) + ((kwh - 100) * 0.75);
        else
            total = (100 * 0.50) + (100 * 0.75) + ((kwh - 200) * 1);

        Console.WriteLine("Total a pagar: " + total);
    }
}