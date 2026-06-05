using System;

class Program
{
    static void Main()
    {
        double temperatura;

        Console.Write("Temperatura: ");
        temperatura = Convert.ToDouble(Console.ReadLine());

        if (temperatura < 10)
            Console.WriteLine("Hace frío");
        else if (temperatura <= 25)
            Console.WriteLine("Clima agradable");
        else
            Console.WriteLine("Hace calor");
    }
}