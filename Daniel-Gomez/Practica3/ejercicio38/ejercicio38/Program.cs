using System;

class Program
{
    static void Main()
    {
        double distancia, costo;
        int hora;

        Console.Write("Distancia (km): ");
        distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Hora: ");
        hora = Convert.ToInt32(Console.ReadLine());

        if (distancia <= 5)
            costo = 10;
        else if (distancia <= 15)
            costo = 20;
        else
            costo = 35;

        if (hora >= 22)
            costo += costo * 0.25;

        Console.WriteLine("Costo: " + costo + " Bs");
    }
}