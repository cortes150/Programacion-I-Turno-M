using System;

class Program
{
    static void Main()
    {
        double tiempo;
        double MinTiempo = double.MaxValue;

        Console.Write("Ingrese tiempo: ");
        tiempo = Convert.ToDouble(Console.ReadLine());

        while (tiempo != 0)
        {
            if (tiempo < MinTiempo)
            {
                MinTiempo = tiempo;
            }

            Console.Write("Ingrese tiempo: ");
            tiempo = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Menor tiempo: " + MinTiempo);
    }
}