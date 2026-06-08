using System;

class Program
{
    static void Main()
    {
        int n1, n2, n3;

        Console.Write("Número 1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Número 2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Número 3: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2 && n1 > n3)
            Console.WriteLine("Mayor: " + n1);
        else if (n2 > n3)
            Console.WriteLine("Mayor: " + n2);
        else
            Console.WriteLine("Mayor: " + n3);
    }
}