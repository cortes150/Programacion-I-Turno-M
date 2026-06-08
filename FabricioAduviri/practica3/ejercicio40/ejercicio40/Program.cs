using System;

class Program
{
    static void Main()
    {
        double estatura;
        string finSemana;
        double precio;

        Console.Write("Estatura: ");
        estatura = Convert.ToDouble(Console.ReadLine());

        Console.Write("¿Fin de semana? (SI/NO): ");
        finSemana = Console.ReadLine();

        if (estatura < 1)
            precio = 0;
        else if (estatura <= 1.5)
            precio = 20;
        else
            precio = 40;

        if (finSemana == "SI")
            precio += 10;

        Console.WriteLine("Total: " + precio + " Bs");
    }
}
