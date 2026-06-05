using System;

class Program
{
    static void Main()
    {
        int D;
        Console.Write("Ingrese la distancia:");
        D=Convert.ToInt32(Console.ReadLine());
        if (D < 3)
        {
            Console.WriteLine("Costo: 5 Bs");
        }
        else
        {
            if (D <= 10)
            {
                Console.WriteLine("Costo 10 Bs");
            }
            else { Console.WriteLine("Costo 20 Bs"); }
        }
    }
}