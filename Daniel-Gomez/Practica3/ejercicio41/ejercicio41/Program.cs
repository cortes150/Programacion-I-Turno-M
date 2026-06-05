using System;

class Program
{
    static void Main()
    {
        double promedio, asistencia;

        Console.Write("Promedio: ");
        promedio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Asistencia: ");
        asistencia = Convert.ToDouble(Console.ReadLine());

        if (promedio >= 80 && asistencia > 85)
            Console.WriteLine("Accede a la beca");
        else
            Console.WriteLine("No accede a la beca");
    }
}