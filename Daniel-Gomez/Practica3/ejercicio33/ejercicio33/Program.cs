using System;

class Program
{
    static void Main()
    {
        int E, I;
        Console.Write("Ingrese su edad: ");
        E=Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese cuanto tiene:");
        I=Convert.ToInt32(Console.ReadLine());
        if (E >= 18 && I > 2500)
        {
            Console.WriteLine("PUEDE ACCEDER AL PRESTAMO");
        }
        else { Console.WriteLine("NO PUEDE ACCEDER"); }
    }
}
