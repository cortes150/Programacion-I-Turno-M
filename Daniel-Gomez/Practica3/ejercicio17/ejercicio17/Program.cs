using System;

class Ejercicio17
{
    static void Main()
    {
        int CC;
        double ST, DC, T;
        Console.Write("Ingrese la cantidad de cajas: ");
        CC=Convert.ToInt32(Console.ReadLine());
        ST = CC * 40;
        if (ST > 5)
        {
            DC = ST * 0.15;
        }
        else
        {
            DC = 0;
        }
        T = ST - DC;
        Console.WriteLine(T);
    }
}
