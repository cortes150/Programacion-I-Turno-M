using System;

class Program
{
    static void Main()
    {
        double peso;

        Console.Write("Peso del perro: ");
        peso = Convert.ToDouble(Console.ReadLine());

        if (peso < 5)
            Console.WriteLine("Pequeño");
        else if (peso <= 20)
            Console.WriteLine("Mediano");
        else
            Console.WriteLine("Grande");
    }
}