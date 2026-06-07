using System;
class Program
{
    static void Main()
    {
        int menores = 0;
        int adultos = 0;
        int edad;
        Console.Write("Ingresar edad(-1 para terminar: ");
        edad=Convert.ToInt32(Console.ReadLine());
        while (edad >= 0)
        {
            if (edad < 18)
            {
                menores++;
            }
            else 
            {
                adultos++;
            }
            Console.Write("Ingresar edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Menores: " + menores);
        Console.WriteLine("Mayotes: " + adultos);
    }
}