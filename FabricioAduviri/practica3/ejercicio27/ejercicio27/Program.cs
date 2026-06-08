using System;

class Program
{
    static void Main()
    {
        string? Gusto;
        Console.Write("Elija su gusto: ");
        Gusto=Console.ReadLine();
        
        if( Gusto == "matematicas") 
        {
            Console.WriteLine("INGENIERIA");
        }
        else 
        {
            if (Gusto == "Diseño")
            {
                Console.WriteLine("MULTIMEDIA");
            }
            else { Console.WriteLine("AUDITORIA"); }
        }
        Console.WriteLine("Ingresaste: " + Gusto);
    }
}