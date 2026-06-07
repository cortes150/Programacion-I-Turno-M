using System;

class Program
{
    static void Main()
    {
        int intentos = 0;
        string palabraSecreta = "hola";
        string palabra;

        Console.Write("Ingrese palabra: ");
        palabra = Console.ReadLine();

        while (palabra != palabraSecreta)
        {
            intentos++;

            Console.Write("Ingrese palabra: ");
            palabra = Console.ReadLine();
        }

        intentos++;

        Console.WriteLine("Intentos: " + intentos);
    }
}