using System;

class Program
{
    static void Main()
    {
        int N1, N2, N3;
        Console.Write("cantidad:");
        N1 = Convert.ToInt32(Console.ReadLine());
        N2 = N1 * 15;
        if (N1 >= 3)
        {
            N3 = N2 - 10;
        }
        else
        {
            N3 = N2;
        }
        Console.WriteLine("Pagar:" + N3);
    }
}
