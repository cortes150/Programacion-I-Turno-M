using System;

class PEjercicio13
{
    static void Main()
    {
        int a;
        double b, c, d;
        Console.Write("ingrese la cantidad de juegos:");
        a = Convert.ToInt32(Console.ReadLine());
        b = a * 12;
        if (a >= 5)
        { 
           c=b*0.25;
        }
        else
        {
            c = 0;
        }
        d = b - c;
        Console.WriteLine("Debe pagar:" + d);
    }
}
