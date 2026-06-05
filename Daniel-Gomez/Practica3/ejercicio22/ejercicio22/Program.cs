using System;

class Program
{
    static void Main()
    {
        double T1, T2, T3;
        Console.Write("Agregue el tiempo del atleta 1: ");
        T1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Agregue el tiempo del atleta 2: ");
        T2= Convert.ToDouble(Console.ReadLine());
        Console.Write("Agregue el tiempo del atleta 3: ");
        T3= Convert.ToDouble(Console.ReadLine());
        if (T1 < T2 && T1 < T3)
        {
            Console.WriteLine("Ganador atleta 1");
        }
        else
        {
            if (T2 < T3)
            {
                Console.WriteLine("Ganador atleta 2");
            }
            else { Console.WriteLine("Ganador atleta 3"); }
        }
    }
}
