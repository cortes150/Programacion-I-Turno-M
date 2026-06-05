using System;

class Ejercicio14
{
    static void Main()
    {
        int CJ;
        double ST, DC, T;
        Console.Write("Ingrese la cantidad de juegos:");
        CJ=Convert.ToInt32(Console.ReadLine());
        ST = CJ * 250;
        if (CJ >= 2)
        {
            DC = ST * 0.15;
        }
        else 
        {
            DC = 0;
        }
        T = ST - DC;
        Console.WriteLine("El total a pagar es:" + T);
    }
}