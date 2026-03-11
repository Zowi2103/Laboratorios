using System;
class Program
{
static void Main()
    {
        int contador = 1;
        int aprobado = 0;
        int reprobado = 0;
        double nota;
        double suma = 0;
        double promedio;

        do
        {
            Console.Write("Ingrese la nota del estudiante " + contador + ": ");
            nota = Convert.ToDouble(Console.ReadLine());

            suma = suma + nota;

            if (nota >= 61)
            {
                aprobado++;
            }
            else
            {
                reprobado++;
            }

            contador++;

        } while (contador <= 10);

        promedio = suma / 10;

        Console.WriteLine("Cantidad de aprobados: " + aprobado);
        Console.WriteLine("Cantidad de reprobados: " + reprobado);
        Console.WriteLine("Promedio de notas: " + promedio);
    }
}