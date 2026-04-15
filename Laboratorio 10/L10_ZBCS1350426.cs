using System;
class Program
{
    static void Main()
    {
        // ejercicio 1

        Console.Write("\nIngresa un número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        int suma = SumarDigitos(numero);
        Console.WriteLine("Suma de dígitos: " + suma);

        // ejercicio 2

        Console.Write("\nIngresa un número entero: ");
        int numRef = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor antes: N = " + numRef);
        string mensaje = ElevarAlCuadrado(ref numRef);
        Console.WriteLine("Valor después: N = " + numRef);
        Console.WriteLine(mensaje);

        // ejercicio 3

        Console.Write("\nIngresa el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el porcentaje de descuento (ej. 0.25): ");
        double descuento = double.Parse(Console.ReadLine());

        Console.WriteLine("Precio antes: Q" + precio);
        double montoDescontado = AplicarDescuento(descuento, ref precio);
        Console.WriteLine("Precio final: Q" + precio);
        Console.WriteLine("Descuento aplicado: Q" + montoDescontado);

        // ejercicio 1.1

        Console.Write("\nIngresa una palabra o frase: ");
        string texto = Console.ReadLine();

        int vocales = ContarVocales(texto);
        Console.WriteLine("Cantidad de vocales: " + vocales);

        // ejercicio 5

        int energiaJugador = 10;
        Console.WriteLine("\n[Ejercicio 5] Energía inicial: " + energiaJugador);

        int restante = ConsumirEnergia(ref energiaJugador);
        Console.WriteLine("Después de consumir energía: " + restante);

        int actual = RecargarEnergia(ref energiaJugador);
        Console.WriteLine("Después de recargar energía: " + actual);

        string estado = ObtenerEstado(energiaJugador);
        Console.WriteLine("Estado de energía: " + estado);

        string rendimiento = CalcularRendimiento(energiaJugador);
        Console.WriteLine("Rendimiento: " + rendimiento);
    }

    // Ejercicio 1
    static int SumarDigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        return suma;
    }

    // Ejercicio 2
    static string ElevarAlCuadrado(ref int num)
    {
        num = num * num;
        return "Operación realizada correctamente.";
    }

    // Ejercicio 3
    static double AplicarDescuento(double descuento, ref double precio)
    {
        double monto = precio * descuento;
        precio = precio - monto;
        return monto;
    }

    // Ejercicio 1.1
    static int ContarVocales(string texto)
    {
        int contador = 0;
        texto = texto.ToLower();

        for (int i = 0; i < texto.Length; i++)
        {
            char c = texto[i];

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                contador++;
            }
        }

        return contador;
    }

    // Ejercicio 5.1
    static int ConsumirEnergia(ref int energia)
    {
        energia -= 4;

        if (energia < 0)
        {
            energia = 0;
        }

        return energia;
    }

    // Ejercicio 5.2
    static int RecargarEnergia(ref int energia)
    {
        energia += 6;

        if (energia > 20)
        {
            energia = 20;
        }

        return energia;
    }

    // Ejercicio 5.3

    static string ObtenerEstado(int energia)
    {
        if (energia >= 15 && energia <= 20)
        {
            return "Alta";
        }
        else if (energia >= 8 && energia <= 14)
        {
            return "Media";
        }
        else
        {
            return "Baja";
        }
    }

    // Ejercicio 5.4
    static string CalcularRendimiento(int energia)
    {
        if (energia == 20)
        {
            return "S";
        }
        else if (energia >= 15)
        {
            return "A";
        }
        else if (energia >= 8)
        {
            return "B";
        }
        else
        {
            return "C";
        }
    }
}