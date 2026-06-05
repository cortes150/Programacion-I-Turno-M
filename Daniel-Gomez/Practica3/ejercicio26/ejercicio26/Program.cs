using System;

class Program
{
    static void Main()
    {
        int AE;
        Console.Write("Ingrese sus años de experiencia: ");
        AE = Convert.ToInt32(Console.ReadLine());
        if (AE > 5)
        {
            Console.WriteLine("CONTRATADO");
        }
        else
        {
            if (AE >= 2)
            {
                Console.WriteLine("EVALUACION ADICIONAL");
            }
            else { Console.WriteLine("RECHAZADO"); }
        }
    }
}
