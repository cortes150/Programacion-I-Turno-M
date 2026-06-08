using System;

class Program
{
    static void Main()
    {
        int H;
        Console.Write("Ingrese el tiempo: ");
        H= Convert.ToInt32(Console.ReadLine());
        if (H < 2) 
        {
            Console.WriteLine("Costo 10Bs");
        }
        else 
        {
            if (H <= 5)
            {
                Console.WriteLine("Costo 20Bs");
            }
            else { Console.WriteLine("Costo 35Bs"); }

        }
    }
}