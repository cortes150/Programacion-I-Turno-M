using System;

class Program
{
    static void Main()
    {
        double P, I, T;
        Console.Write("Agregue el precio del producto: ");
        P=Convert.ToDouble(Console.ReadLine());
        if (P > 1000)
        {
            I = P * 0.13;
        }
        else
        {
            I = 0;
        }
        T = P - I;
        Console.WriteLine("el monto a pagar es: " + T);
    }
}