using System;

class Ejercicio16
{
    static void Main()
    {
        int CC;
        double ST, DC, T;
        Console.Write("Ingrese la cantidad de cuadernos:");
        CC=Convert.ToInt32(Console.ReadLine());
        ST = CC * 18;
        if (CC > 10)
        {
            DC = ST * 0.30;
        }
        else
        {
            DC = 0;
        }
        T = ST - DC;
        Console.WriteLine("El total a pagar es " + T);
    }
}