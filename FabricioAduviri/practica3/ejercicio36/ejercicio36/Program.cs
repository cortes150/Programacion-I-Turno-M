using System;

class Program
{
    static void Main()
    {
        int num;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positivo");
        else if (num < 0)
            Console.WriteLine("Negativo");
        else
            Console.WriteLine("Cero");
    }
}