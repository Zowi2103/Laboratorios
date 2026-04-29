using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione ejercicio (1-4): ");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1: Ejercicio1(); break;
            case 2: Ejercicio2(); break;
            case 3: Ejercicio3(); break;
            case 4: Ejercicio4(); break;
            default: Console.WriteLine("Elija una opcion de 1 a 4"); break;
        }
    }
    static void Ejercicio1()
    {
        int[,] m = new int[4, 4];
        Llenar4x4(m);

        Console.Write("Fila (0-3): ");
        int f = int.Parse(Console.ReadLine());
        Console.Write("Columna (0-3): ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma fila: " + SumaFila(m, f));
        Console.WriteLine("Suma columna: " + SumaColumna(m, c));
    }

    static void Llenar4x4(int[,] m)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaFila(int[,] m, int fila)
    {
        int s = 0;
        for (int j = 0; j < 4; j++)
            s += m[fila, j];
        return s;
    }

    static int SumaColumna(int[,] m, int col)
    {
        int s = 0;
        for (int i = 0; i < 4; i++)
            s += m[i, col];
        return s;
    }
    static void Ejercicio2()
    {
        float[,] m = new float[3, 5];
        CargarMatriz(m);
        Console.WriteLine("Mayor: " + MayorMatriz(m));
    }

    static void CargarMatriz(float[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
    }

    static float MayorMatriz(float[,] m)
    {
        float mayor = m[0, 0];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                if (m[i, j] > mayor)
                    mayor = m[i, j];
        return mayor;
    }

    static void Ejercicio3()
    {
        int[,] A = new int[2, 3];
        int[,] B = new int[3, 2];

        LlenarA(A);
        LlenarB(B);

        int[,] R = Multiplicar(A, B);

        Console.WriteLine("Resultado:");
        Mostrar(R);
    }

    static void LlenarA(int[,] m)
    {
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static void LlenarB(int[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int[,] Multiplicar(int[,] A, int[,] B)
    {
        int[,] R = new int[2, 2];

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 3; k++)
                    R[i, j] += A[i, k] * B[k, j];

        return R;
    }

    static void Mostrar(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(m[i, j] + "\t");
            Console.WriteLine();
        }
    }
    static void Ejercicio4()
    {
        int[,] m = new int[5, 5];
        Llenar5x5(m);

        Console.WriteLine("Diagonal principal: " + SumaDP(m));
        Console.WriteLine("Diagonal secundaria: " + SumaDS(m));
    }

    static void Llenar5x5(int[,] m)
    {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaDP(int[,] m)
    {
        int s = 0;
        for (int i = 0; i < 5; i++)
            s += m[i, i];
        return s;
    }

    static int SumaDS(int[,] m)
    {
        int s = 0;
        for (int i = 0; i < 5; i++)
            s += m[i, 4 - i];
        return s;
    }
}