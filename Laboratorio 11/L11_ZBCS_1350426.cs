using System;
class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n MENÚ ");
            Console.WriteLine("1. Validación de contraseña");
            Console.WriteLine("2. Invertir texto");
            Console.WriteLine("3. Arreglos");
            Console.WriteLine("4. Buscar un número en arreglo");
            Console.WriteLine("5. Nombres en arreglo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1: ValidarContraseña(); break;
                case 2: InvertirTexto(); break;
                case 3: SumaPromedio(); break;
                case 4: BuscarNumero(); break;
                case 5: NombresArreglo(); break;
            }

        } while (opcion != 0);
    }

    static void ValidarContraseña()
    {
        Console.Write("Ingrese una contraseña: ");
        string contraseña = Console.ReadLine();

        bool mayus = false, num = false, esp = false;

        foreach (char c in contraseña)
        {
            if (char.IsUpper(c)) mayus = true;
            else if (char.IsDigit(c)) num = true;
            else if (!char.IsLetterOrDigit(c)) esp = true;
        }

        string errores = "";

        if (contraseña.Length < 8)
            errores += "falta longitud (8), ";

        if (!mayus)
            errores += "falta mayúscula, ";

        if (!num)
            errores += "falta número, ";

        if (!esp)
            errores += "falta carácter especial, ";

        if (errores == "")
            Console.WriteLine("Contraseña válida");
        else
        {
            errores = errores.TrimEnd(',', ' ');
            Console.WriteLine("Inválida: " + errores);
        }
    }

    static void InvertirTexto()
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertido);
    }

    static void SumaPromedio()
    {
        Console.Write("¿Cuántos números?: ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int suma = 0, mayor = nums[0], menor = nums[0];

        for (int i = 0; i < n; i++)
        {
            suma += nums[i];

            if (nums[i] > mayor) mayor = nums[i];
            if (nums[i] < menor) menor = nums[i];
        }

        double promedio = (double)suma / n;

        Console.WriteLine("Suma = " + suma);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
        Console.WriteLine("Menor = " + menor);
    }

    static void BuscarNumero()
    {
        int[] nums = new int[8];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int buscado = int.Parse(Console.ReadLine());

        int pos = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == buscado)
            {
                pos = i;
                break;
            }
        }

        if (pos != -1)
            Console.WriteLine("Sí existe en la posición " + pos);
        else
            Console.WriteLine("No existe en el arreglo");
    }

    static void NombresArreglo()
    {
        string[] nombres = new string[5];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();
        }

        int count = 0;
        string largo = nombres[0];

        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i].Length > 5)
                count++;

            if (nombres[i].Length > largo.Length)
                largo = nombres[i];
        }

        Console.Write("Nombres: ");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write(nombres[i]);
            if (i < nombres.Length - 1) Console.Write(", ");
        }

        Console.WriteLine();
        Console.WriteLine("Más de 5 letras: " + count);
        Console.WriteLine("Nombre más largo: " + largo);
    }
}