using System;

class Program
{
    static void Main()
    {
        double monto, total;
        string pago;

        Console.Write("Monto: ");
        monto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Método de pago: ");
        pago = Console.ReadLine();

        if (pago == "Efectivo")
            total = monto - (monto * 0.15);
        else if (pago == "Tarjeta")
            total = monto - (monto * 0.05);
        else
            total = monto - (monto * 0.10);

        Console.WriteLine("Total: " + total);
    }
}