using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1
        
        int N = 0;
        while (N <= 0)
        {
            Console.Write("¿Cuántos números desea sumar? ");
            N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Error: Ingrese otro número diferente de 0");
            }
        }

        int contador = 0;
        double numero;
        double suma = 0;

        while (contador < N)
        {
            Console.Write("Ingrese el número " + (contador + 1) + ": ");
            numero = double.Parse(Console.ReadLine());

            suma = suma + numero;
            contador++; 
        }

        double promedio = suma / N;


        Console.WriteLine("\nResultados:");
        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);

        //Ejercicio 2

        int opcion;

        do
        {
            Console.Write("Seleccione una opción: ");
            Console.WriteLine("1. Convertir Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir Fahrenheit a Celsius");
            Console.WriteLine("3. Convertir Kilómetros a Millas");
            Console.WriteLine("4. Salir");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese grados Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("Resultado: " + fahrenheit.ToString("F2") + " °F");
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese grados Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());

                double celsius = (fahrenheit - 32) * 5 / 9;

                Console.WriteLine("Resultado: " + celsius.ToString("F2") + " °C");
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese kilómetros: ");
                double km = double.Parse(Console.ReadLine());

                double millas = km * 0.621371;

                Console.WriteLine("Resultado: " + millas.ToString("F2") + " millas");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opción inválida. Seleccione otra opción");
            }

        } while (opcion != 4);

        //Ejercicio 3

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        int intento = 0;
        int intentos = 0;

        while (intento != numeroSecreto)
        {
            Console.Write("Ingrese un número entre 1 y 100: ");
            intento = int.Parse(Console.ReadLine());

            if (intento < 1 || intento > 100)
            {
                Console.WriteLine("Número inválido.");
            }

            intentos++;

            if (intento < numeroSecreto)
            {
                Console.WriteLine("Más alto");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("Más bajo");
            }
        }

        Console.WriteLine("Correcto!");
        Console.WriteLine("Felicidades! Adivinaste el número en " + intentos + " intentos.");
    }
}