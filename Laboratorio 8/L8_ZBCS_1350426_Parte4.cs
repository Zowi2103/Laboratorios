using System;
class Program
{
    static void Main()
    {
        int numero;
        int total = 0;
        int positivos = 0;
        int negativos = 0;
        int suma = 0;

        Console.Write("Ingrese un número (0 para finalizar): ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (numero != 0)
        {
            total++;
            suma += numero;

            if (numero > 0)
            {
                positivos++;
            }
            else
            {
                negativos++;
            }

            Console.Write("Ingrese otro número (0 para finalizar): ");
            numero = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Total de números ingresados: " + total);
        Console.WriteLine("Cantidad de positivos: " + positivos);
        Console.WriteLine("Cantidad de negativos: " + negativos);
        Console.WriteLine("Suma total: " + suma);
    }
}
