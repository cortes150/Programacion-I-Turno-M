using System;

class Program
{
    static void Main()
    {
        int ContadorFiebre = 0;
        double temperatura;

        Console.Write("Ingrese temperatura: ");
        temperatura = Convert.ToDouble(Console.ReadLine());

        while (temperatura != 0)
        {
            if (temperatura > 38)
            {
                ContadorFiebre++;
            }

            Console.Write("Ingrese temperatura: ");
            temperatura = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Pacientes con fiebre: " + ContadorFiebre);
    }
}