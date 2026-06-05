using System;

class Program
{
    static void Main()
    {
        double innovacion, presentacion;

        Console.Write("Innovación: ");
        innovacion = Convert.ToDouble(Console.ReadLine());

        Console.Write("Presentación: ");
        presentacion = Convert.ToDouble(Console.ReadLine());

        if (innovacion > 80 && presentacion > 80)
            Console.WriteLine("Ganador");
        else if (innovacion > 60)
            Console.WriteLine("Destacado");
        else
            Console.WriteLine("Participante");
    }
}