using System;

class Program
{
    static void Main()
    {
        int Contador300 = 0;
        int paginas;

        Console.Write("Ingrese páginas: ");
        paginas = Convert.ToInt32(Console.ReadLine());

        while (paginas != 0)
        {
            if (paginas > 300)
            {
                Contador300++;
            }

            Console.Write("Ingrese páginas: ");
            paginas = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Libros con más de 300 páginas: " + Contador300);
    }
}