using System;

class Ejercicio4
{
    static void Main()
    {
        int horas, pagohora, salario;
        Console.Write("horas trabajadas:");
        horas = Convert.ToInt32(Console.ReadLine());
        Console.Write("pago por hora:");
        pagohora = Convert.ToInt32(Console.ReadLine());
        salario = horas * pagohora;
        Console.WriteLine("se te pagara:" + salario);
    }
}
