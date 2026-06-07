using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Ingrese número: ");
        n = Convert.ToInt32(Console.ReadLine());

        bool primo = true;

        if (n <= 1)
        {
            primo = false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                primo = false;
            }
        }

        if (primo)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No es primo");
        }
    }
}