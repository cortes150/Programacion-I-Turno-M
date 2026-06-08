using System;

class Program
{
    static void Main()
    {
        int P;
        Console.Write("Puntos: ");
        P=Convert.ToInt32(Console.ReadLine());
        if (P > 1000)
        {
            Console.WriteLine("3 vidas extras");
        }
        else
        {
            if (P >= 500)
            {
                Console.WriteLine("2 vidas extras");
            }
            else
            {
                Console.WriteLine("1 vida extra");
            }
        }
    }
}