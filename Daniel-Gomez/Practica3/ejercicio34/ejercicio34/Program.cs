using System;

class Program
{
    static void Main()
    {
        double dinero, precio;

        Console.Write("Ingrese dinero: ");
        dinero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese precio del producto: ");
        precio = Convert.ToDouble(Console.ReadLine());

        if (dinero >= precio)
        {
            Console.WriteLine("Entrega producto");
        }
        else
        {
            Console.WriteLine("Dinero insuficiente");
        }
    }
}