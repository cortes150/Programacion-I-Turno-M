using System;

class Program
{
    static void Main()
    {
        double consumo;

        Console.Write("Monto consumido: ");
        consumo = Convert.ToDouble(Console.ReadLine());

        if (consumo > 500)
            Console.WriteLine("Cena gratis para la próxima visita");
        else if (consumo > 200)
            Console.WriteLine("Postre y bebida gratis");
        else if (consumo > 100)
            Console.WriteLine("Postre gratis");
        else
            Console.WriteLine("Sin premio");
    }
}