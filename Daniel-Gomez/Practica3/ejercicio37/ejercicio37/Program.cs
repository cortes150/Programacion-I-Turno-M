using System;

class Program
{
    static void Main()
    {
        int edad;

        Console.Write("Edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 13)
            Console.WriteLine("Infantil");
        else if (edad <= 17)
            Console.WriteLine("Adolescente");
        else
            Console.WriteLine("Adultos");
    }
}

