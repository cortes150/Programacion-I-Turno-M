using System;

class Program
{
    static void Main()
    {
        int n;
        int numero = 1;

        Console.Write("Ingrese cantidad: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(-numero);
            }
            else
            {
                Console.WriteLine(numero);
            }

            numero++;
        }
    }
}