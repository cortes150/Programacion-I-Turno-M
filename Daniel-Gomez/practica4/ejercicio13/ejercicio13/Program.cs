using System;

class Program
{
    static void Main()
    {
        double Suma = 0;
        int Cantidad = 0;
        double puntaje;

        Console.Write("Ingrese puntaje: ");
        puntaje = Convert.ToDouble(Console.ReadLine());

        while (puntaje != 0)
        {
            Suma = Suma + puntaje;
            Cantidad++;

            Console.Write("Ingrese puntaje: ");
            puntaje = Convert.ToDouble(Console.ReadLine());
        }

        if (Cantidad > 0)
        {
            double Promedio = Suma / Cantidad;
            Console.WriteLine("Promedio: " + Promedio);
        }
        else
        {
            Console.WriteLine("Promedio: 0");
        }
    }
}