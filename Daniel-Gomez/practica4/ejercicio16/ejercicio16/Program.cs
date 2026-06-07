using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Ingrese N: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}