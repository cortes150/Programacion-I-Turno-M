using System;

class Program
{
    static void Main()
    {
        int A, B;
        Console.Write("ingrese numero:");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("ingrese siguiente numero:");
        B = Convert.ToInt32(Console.ReadLine());
        if (A > B)
        {
            Console.WriteLine("el nunmero mayor es:" + A);
        }
        else
            Console.WriteLine("el numero mayor es:" + B);
    }
}