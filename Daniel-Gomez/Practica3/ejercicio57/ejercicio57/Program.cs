using System;

class Program
{
    static void Main()
    {
        int materias;
        double promedio, total;

        Console.Write("Cantidad de materias: ");
        materias = Convert.ToInt32(Console.ReadLine());

        Console.Write("Promedio: ");
        promedio = Convert.ToDouble(Console.ReadLine());

        total = materias * 120;

        if (materias > 5)
            total -= total * 0.20;

        if (promedio > 85)
            total -= total * 0.10;

        Console.WriteLine("