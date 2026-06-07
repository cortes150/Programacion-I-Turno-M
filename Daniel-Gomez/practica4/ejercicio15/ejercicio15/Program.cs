using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        double horas;

        Console.Write("Ingrese horas: ");
        horas = Convert.ToDouble(Console.ReadLine());

        while (horas != 0)
        {
            if (horas > 2)
            {
                contador++;
            }

            Console.Write("Ingrese horas: ");
            horas = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Clientes con más de 2 horas: " + contador);
    }
}