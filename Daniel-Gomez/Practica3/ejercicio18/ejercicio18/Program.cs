using System;

class Ejercicio18
{
    static void Main()
    {
        int N;
        Console.Write("Ingrese nota :");
        N=Convert.ToInt32(Console.ReadLine());
        if (N >= 51) 
        {
            Console.WriteLine("Aprobo");
        }
        else 
        {
            Console.WriteLine("Reprobo");
        }
    }
}
