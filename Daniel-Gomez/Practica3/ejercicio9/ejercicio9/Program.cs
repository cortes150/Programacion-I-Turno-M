internal class Ejercicio9
{
    private static void Main(string[] args)
    {
        int N1, descuento, N2;
        Console.Write("agregue monto:");
        N1 = Convert.ToInt32(Console.ReadLine());
        if (N1 > 100)
        {
            descuento = N1 * 10 / 100;
        }
        else
        {
            descuento = 0;
        }
        N2 = N1 - descuento;
        Console.WriteLine("Su monto a pagar es" + N2);
    }
}