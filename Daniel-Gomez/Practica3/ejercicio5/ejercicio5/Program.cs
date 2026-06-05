using System;

class Program
{
    static void Main()
    {
        int metros, centimetros;
        Console.Write("cuantos metros desea convertir:");
        metros = Convert.ToInt32(Console.ReadLine());
        centimetros = metros * 100;
        Console.WriteLine("en centimetros es:" + centimetros);
    }
}