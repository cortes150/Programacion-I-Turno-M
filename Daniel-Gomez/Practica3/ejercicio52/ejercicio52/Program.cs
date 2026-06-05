using System;

class Program
{
    static void Main()
    {
        double peso;

        Console.Write("Peso del equipaje: ");
        peso = Convert.ToDouble(Console.ReadLine());

        if (peso < 20)
            Console.WriteLine("Sin recargo");
        else if (peso <= 30)
            Console.WriteLine("Recargo de 50 Bs");
        else
            Console.WriteLine("Recargo de 100 Bs");
    }
}