using System;
using System.ComponentModel.Design;

class Ejercicio7
{
    static void Main()
    {
        int N;
        Console.Write("inserte un numero:");
        N = Convert.ToInt32(Console.ReadLine());
        if (N / 2 == 0) 
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
    }
}