using System;

class Ejercicio21
{
    static void Main()
    {
        double saldo, monto;
        Console.Write("Ingrese saldo:");
        saldo=Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese monto:");
        monto=Convert.ToDouble(Console.ReadLine());
        if (saldo <= monto)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Console.WriteLine("Operacion valida");
        }
    }
}