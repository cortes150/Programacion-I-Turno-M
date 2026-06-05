using System;

class Program
{
    static void Main()
    {
        int D, C;
        Console.Write("Ingrese dinero disponible: ");
        D = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese costo del vuelo: ");
        C = Convert.ToInt32(Console.ReadLine());
        if (D >= C) 
        {
            Console.WriteLine("PUEDE VIAJAR");
        }
        else
        {
            Console.WriteLine("NO PUEDE VIAJAR");
        }
    }
}