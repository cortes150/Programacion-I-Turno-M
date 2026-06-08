using System;

class Program
{
    static void Main()
    {
        int N1;
        Console.Write("Ingresa tu edad:");
        N1 = Convert.ToInt32(Console.ReadLine());
        if (N1 >= 18)
        {
            Console.WriteLine("Mayor de edad");
        }
        else
        {
            Console.WriteLine("Menor de edad");

        }
    }
}