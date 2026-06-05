using System;

class Program
{
    static void Main()
    {
        string Lluvia;
        Console.Write("Esta lloviendo?:");
        Lluvia = Console.ReadLine();
        if (Lluvia == "SI")
        {
            Console.WriteLine("No regar");
        }
        else { Console.WriteLine("Regar"); }
    }
}