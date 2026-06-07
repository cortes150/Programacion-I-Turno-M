using System;

class Program
{
    static void Main()
    {
        int pin = 1234;
        int intento;
        int contador = 0;

        while (contador < 3)
        {
            Console.Write("Ingrese PIN: ");
            intento = Convert.ToInt32(Console.ReadLine());

            if (intento == pin)
            {
                Console.WriteLine("Acceso permitido");
                break;
            }

            contador++;
        }

        if (contador == 3)
        {
            Console.WriteLine("Tarjeta bloqueada");
        }
    }
}