using System;

class Program
{
    static void Main()
    {
        double promedio;

        Console.Write("Promedio: ");
        promedio = Convert.ToDouble(Console.ReadLine());

        if (promedio >= 90)
            Console.WriteLine("Excelente");
        else if (promedio >= 70)
            Console.WriteLine("Bueno");
        else if (promedio >= 51)
            Console.WriteLine("Regular");
        else
            Console.WriteLine("Reprobado");
    }
}
