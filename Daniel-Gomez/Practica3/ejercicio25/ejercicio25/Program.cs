using System;

class Program
{
    static void Main()
    {
        double T;
        Console.Write("Ingrese su temperatura: ");
        T=Convert.ToDouble(Console.ReadLine());
        if (T < 36) 
        {
            Console.WriteLine("HIPOTERMIA");
        }
        else 
        {
            if (T <= 37.5) 
            {
                Console.WriteLine("Normal");
            }
            else 
            {
                Console.WriteLine("FIEBRE");
            }
        }
    }
}