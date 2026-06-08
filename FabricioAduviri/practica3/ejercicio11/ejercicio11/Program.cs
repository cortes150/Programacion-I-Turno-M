internal class Ejercicio11
{
    private static void Main(string[] args)
    {
        int N1, N2, N3, N4;
        Console.Write("ingrese la cantidad de personas:");
        N1 = Convert.ToInt32(Console.ReadLine());
        N2 = N1 * 35;
        if (N1 > 4)
        {
            N3 = N2 * 20 / 100;

        }
        else
        {
            N3 = 0;
        }
        N4 = N2 - N3;
        Console.WriteLine(N4);

    }
}