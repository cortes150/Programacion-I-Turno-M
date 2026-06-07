using System;

class Program
{
    static void Main()
    {
        int cantidad;
        double nota;
        double suma = 0;

        Console.Write("Cantidad de estudiantes: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Nota " + i + ": ");
            nota = Convert.ToDouble(Console.ReadLine());

            suma += nota;
        }

        Console.WriteLine("Promedio: " + (suma / cantidad));
    }
}