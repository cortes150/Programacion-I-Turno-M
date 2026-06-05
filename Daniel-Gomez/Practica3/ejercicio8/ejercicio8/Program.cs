using System;

class Program
{
    static void Main()
    {
        int N1;
        Console.Write("escriba la nota:");
        N1 = Convert.ToInt32(Console.ReadLine());
        if (N1 >= 51)
        {
            Console.WriteLine("aprobo");
        }
        else
            Console.WriteLine("reprobo");
    }
}