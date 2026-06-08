using System;

class Program
{
    static void Main()
    {
        int E;
        Console.Write("Edad: ");
        E = Convert.ToInt32(Console.ReadLine());
        if (E >= 18)
        {
            Console.WriteLine("Puede ingresar");
        }
        else 
        {
            Console.WriteLine("No puede ingresar");
        }
    }
}