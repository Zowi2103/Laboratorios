using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}