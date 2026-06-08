using System;

class Program
{
    static void Main()
    {
        string contraseña, huella;

        Console.Write("Contraseña correcta (SI/NO): ");
        contraseña = Console.ReadLine();

        Console.Write("Huella correcta (SI/NO): ");
        huella = Console.ReadLine();

        if (contraseña == "SI" && huella == "SI")
            Console.WriteLine("Acceso permitido");
        else
            Console.WriteLine("Acceso denegado");
    }
}