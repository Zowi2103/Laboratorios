using System;

class Libro
{
    private string titulo;
    private string autor;
    private int anioPublicacion;
    private bool disponible;

    public Libro(string t, string a, int anio, bool d)
    {
        titulo = t;
        autor = a;
        anioPublicacion = anio;
        disponible = d;
    }

    public void mostrarInformacion()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anioPublicacion);
        Console.WriteLine("Disponible: " + disponible);
        Console.WriteLine();
    }

    public void prestarLibro()
    {
        if (disponible == true)
        {
            disponible = false;
            Console.WriteLine("Prestado");
        }
        else
        {
            Console.WriteLine("No disponible.");
        }
    }

    public void devolverLibro()
    {
        disponible = true;
        Console.WriteLine("Libro devuelto");
    }
}

class Mascota
{
    private string nombre;
    private string especie;
    private int edad;
    private bool vacunado;

    public Mascota(string n, string e, int edadMascota, bool v)
    {
        nombre = n;
        especie = e;
        edad = edadMascota;
        vacunado = v;
    }

    public void mostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Especie: " + especie);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Vacunado: " + vacunado);
    }

    public void vacunar()
    {
        vacunado = true;
        Console.WriteLine(nombre + "Vacunado");
    }

    public void cumplirAnios()
    {
        edad = edad + 1;
        Console.WriteLine(nombre + " ahora tiene " + edad + " años.");
    }
}
class Estudiante
{
    private string nombre;
    private int edad;
    private string grado;
    private double[] notas;

    public Estudiante(string n, int e, string g, double[] nE)
    {
        nombre = n;
        edad = e;
        grado = g;
        notas = nE;
    }

    public double calcularPromedio()
    {
        double suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma = suma + notas[i];
        }

        return suma / notas.Length;
    }

    public void mostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Grado: " + grado);

        Console.Write("Notas: ");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Promedio: " + calcularPromedio());
        Console.WriteLine();
    }
    public void aprobar()
    {
        if (calcularPromedio() >= 61)
        {
            Console.WriteLine(nombre + " aprobado");
        }
        else
        {
            Console.WriteLine(nombre + "rebrobado");
        }
    }

    public void agregarNota(double nuevaNota)
    {
        double[] nuevoArreglo = new double[notas.Length + 1];

        for (int i = 0; i < notas.Length; i++)
        {
            nuevoArreglo[i] = notas[i];
        }

        nuevoArreglo[notas.Length] = nuevaNota;

        notas = nuevoArreglo;

        Console.WriteLine("Nueva nota agregada: " + nuevaNota);
    }
}
class Program
{
    static void Main()
    {
        // EJERCICIO 1

        Libro libro1 = new Libro("Tokio Blues", "Haruki Murakami", 1987, true);

        Libro libro2 = new Libro("El principito", "Antoine de Saint Exupery", 1943, true);

        libro1.mostrarInformacion();
        libro2.mostrarInformacion();

        libro1.prestarLibro();

        Console.WriteLine("Estado:");
        libro1.mostrarInformacion();

        libro1.devolverLibro();

        Console.WriteLine("Estado:");
        libro1.mostrarInformacion();


        // EJERCICIO 2

        Mascota mascota1 = new Mascota("Muffin", "Perro", 1, false);

        Mascota mascota2 = new Mascota("Pichi", "Gato", 3, false);

        mascota1.mostrarInformacion();
        mascota2.mostrarInformacion();

        mascota1.vacunar();

        Console.WriteLine("Estado:");
        mascota1.mostrarInformacion();

        mascota2.cumplirAnios();

        Console.WriteLine("Estado:");
        mascota2.mostrarInformacion();


        // EJERCICIO 3

        double[] notas1 = { 59, 84, 100 };
        double[] notas2 = { 100, 90, 87 };

        Estudiante estudiante1 = new Estudiante("Sofia", 17, "quinto", notas1);

        Estudiante estudiante2 = new Estudiante("Natali", 16, "cuarto", notas2);

        estudiante1.mostrarInformacion();
        estudiante2.mostrarInformacion();

        estudiante1.aprobar();
        estudiante2.aprobar();

        estudiante2.agregarNota(80);

        Console.WriteLine("Información:");

        estudiante2.mostrarInformacion();

        estudiante2.aprobar();
    }
}