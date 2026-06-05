using System;

class Program
{
    static void Main()
    {
        int CP;
        double ST, DC, T;
        Console.Write("Cantidad de pizzas:");
        CP = Convert.ToInt32(Console.ReadLine());
        ST = CP * 80;
        if (CP > 3)
        {
            DC = ST * 0.20;
            Console.WriteLine("REGALO:BEBIDA");
        }
        else
        {
            DC = 0;
        }
        T = ST - DC;
        Console.WriteLine("Se debe pagar en total " + T );
    }
}
