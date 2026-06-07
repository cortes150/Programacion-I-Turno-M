using System;

class Program
{
    static void Main()
    {
        int n;
        int a = 0;
        int b = 1;
        int c;

        Console.Write("Ingrese cantidad: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(a);

            c = a + b;
            a = b;
            b = c;
        }
    }
}