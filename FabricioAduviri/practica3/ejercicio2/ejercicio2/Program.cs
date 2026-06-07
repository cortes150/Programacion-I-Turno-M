using System;
using System.Diagnostics.CodeAnalysis;

class Ejercicio2
{
    static void Main()
    {
        int N1, N2, Suma;
        Console.Write("ingrese primer numero:");
        N1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("ingrese segundo numero:");
        N2 = Convert.ToInt32(Console.ReadLine());

        Suma = N1 + N2;

        Console.WriteLine("el resultado es:" + Suma);
    }
}