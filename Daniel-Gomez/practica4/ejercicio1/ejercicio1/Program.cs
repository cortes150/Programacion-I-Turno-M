using System;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        double monto;
        double total = 0;
        Console.Write("ingrese el monto de la compra:");
        monto=Convert.ToDouble(Console.ReadLine());
        while (monto != 0)
        {
            total = total + monto;
            Console.Write("Ingrese el monto de la compra:");
            monto = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Total de compras: " + total);
    }
}