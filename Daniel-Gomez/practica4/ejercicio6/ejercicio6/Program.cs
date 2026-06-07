using System;
class Program 
{
    static void Main()
    {
        double TotalLitros = 0;
        double litros;
        int Dias = 0;
        Console.Write("Ingrese los litros: ");
        litros = Convert.ToInt32(Console.ReadLine());
        while (litros != 0)
        {
            TotalLitros += litros;
            Dias++;
            Console.Write("Ingrese los litros: ");
            litros= Convert.ToInt32(Console.ReadLine());
        }
        if (Dias > 0)
        {
            double promedio = TotalLitros / Dias;
            Console.Write("el promedio es de " + promedio);
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}