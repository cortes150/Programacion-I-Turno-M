using System;

class Program
{
    static void Main()
    {
        string plan, estudiante;
        double precio;

        Console.Write("Plan (Basico/Premium): ");
        plan = Console.ReadLine();

        Console.Write("¿Es estudiante? (SI/NO): ");
        estudiante = Console.ReadLine().ToUpper();

        if (plan == "Basico")
            precio = 20;
        else
            precio = 50;

        if (estudiante == "SI")
            precio -= precio * 0.30;

        Console.WriteLine("Total a pagar: " + precio);
    }
}