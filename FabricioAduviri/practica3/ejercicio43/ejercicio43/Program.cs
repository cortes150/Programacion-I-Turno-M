using System;

class Program
{
    static void Main()
    {
        int nivel, monedas;

        Console.Write("Nivel: ");
        nivel = Convert.ToInt32(Console.ReadLine());

        Console.Write("Monedas: ");
        monedas = Convert.ToInt32(Console.ReadLine());

        if (nivel > 10 && monedas > 500)
            Console.WriteLine("Espada legendaria");
        else if (nivel > 10)
            Console.WriteLine("Armadura");
        else
            Console.WriteLine("Pociones básicas");
    }
}