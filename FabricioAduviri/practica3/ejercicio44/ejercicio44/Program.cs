using System;

class Program
{
    static void Main()
    {
        int horas, ventas;
        int bono = 0;

        Console.Write("Horas trabajadas: ");
        horas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ventas realizadas: ");
        ventas = Convert.ToInt32(Console.ReadLine());

        if (horas > 8)
            bono += 100;

        if (horas > 8 && ventas > 20)
            bono += 200;

        Console.WriteLine("Bono: " + bono + " Bs");
    }
}