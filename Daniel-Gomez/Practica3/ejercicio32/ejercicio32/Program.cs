using System;

class Program
{
    static void Main()
    {
        int P;
        Console.Write("Ingrese los puntos: ");
        P=Convert.ToInt32(Console.ReadLine());
        if (P > 5000) 
        {
            Console.WriteLine("NIVEL EXPERTO");
        }
        else
        {
            if (P > 2000)
            {
                Console.WriteLine("NIVEL INTERMEDIO");
            }
            else { Console.WriteLine("NIVEL PRINCIPIANTE"); }
        }
    }
}
