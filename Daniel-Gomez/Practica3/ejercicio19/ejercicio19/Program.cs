using System;

class Ejercicio19
{
    static void Main()
    {
        int E;
        Console.Write("Ingrese su edad: ");
        E=Convert.ToInt32(Console.ReadLine());
        if (E < 10) 
        {
            Console.WriteLine("Costo: 15Bs");
        }
        else { Console.WriteLine("Costo: 30Bs"); }
    }
}
