using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Ingrese N: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}