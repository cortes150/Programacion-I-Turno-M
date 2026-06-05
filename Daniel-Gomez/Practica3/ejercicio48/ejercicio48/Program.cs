using System;

class Program
{
    static void Main()
    {
        double asistencia, promedio;

        Console.Write("Asistencia: ");
        asistencia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Promedio: ");
        promedio = Convert.ToDouble(Console.ReadLine());

        if (asistencia > 75 && promedio > 51)
            Console.WriteLine("Puede rendir examen final");
        else
            Console.WriteLine("No puede rendir examen final");
    }
}