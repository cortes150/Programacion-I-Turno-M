using System;

class Program
{
    static void Main()
    {
        double dolares;
        double tipoCambio = 6.96;

        Console.Write("Ingrese dólares (0 para salir): ");
        dolares = Convert.ToDouble(Console.ReadLine());

        while (dolares != 0)
        {
            Console.WriteLine("Bs: " + (dolares * tipoCambio));

            Console.Write("Ingrese dólares (0 para salir): ");
            dolares = Convert.ToDouble(Console.ReadLine());
        }
    }
}