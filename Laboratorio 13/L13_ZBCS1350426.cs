using System;
class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}
class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}
class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}
class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}
class Program
{
    static void Main()
    {
        //Ejercicio 1:
        Persona persona1 = new Persona();
        persona1.nombre = "Zoe";
        persona1.edad = 19;
        persona1.altura = 1.65;
        persona1.estudiante = true;

        Console.WriteLine("Ejercicio 1");
        Console.WriteLine("Nombre: " + persona1.nombre);
        Console.WriteLine("Edad: " + persona1.edad);
        Console.WriteLine("Altura: " + persona1.altura);
        Console.WriteLine("Estudiante: " + persona1.estudiante);

        //Ejercicio 2:
        Vehiculo v1 = new Vehiculo();
        v1.marca = "Nissan";
        v1.modelo = "Sentra";
        v1.anio = 2020;
        v1.color = "Negro";
        v1.placa = "12345Z";

        Console.WriteLine("Ejercicio 2");
        Console.WriteLine("Marca: " + v1.marca);
        Console.WriteLine("Modelo: " + v1.modelo);
        Console.WriteLine("Año: " + v1.anio);
        Console.WriteLine("Color: " + v1.color);
        Console.WriteLine("Placa: " + v1.placa);

        //Ejercicio 3:
        Producto p1 = new Producto();
        p1.codigo = "211725";
        p1.nombre = "Audifonos";
        p1.precio = 890;
        p1.stock = 3;
        p1.disponible = true;

        Producto p2 = new Producto();
        p2.codigo = "030223";
        p2.nombre = "Taza";
        p2.precio = 60;
        p2.stock = 30;
        p2.disponible = true;

        Console.WriteLine("Ejercicio 3");
        Console.WriteLine("Producto 1:");
        Console.WriteLine("Código: " + p1.codigo);
        Console.WriteLine("Nombre: " + p1.nombre);
        Console.WriteLine("Precio: " + p1.precio);
        Console.WriteLine("Stock: " + p1.stock);
        Console.WriteLine("Disponible: " + p1.disponible);
        Console.WriteLine("Producto 2:");
        Console.WriteLine("Código: " + p2.codigo);
        Console.WriteLine("Nombre: " + p2.nombre);
        Console.WriteLine("Precio: " + p2.precio);
        Console.WriteLine("Stock: " + p2.stock);
        Console.WriteLine("Disponible: " + p2.disponible);

        //Ejercicio 4:
        Mascota m1 = new Mascota();
        m1.nombre = "Pichi";
        m1.especie = "Gato";
        m1.edad = 3;
        m1.peso = 4;
        m1.vacunado = true;

        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Nombre: " + m1.nombre);
        Console.WriteLine("Especie: " + m1.especie);
        Console.WriteLine("Edad: " + m1.edad);
        Console.WriteLine("Peso: " + m1.peso);
        Console.WriteLine("Vacunado: " + m1.vacunado);
    }
}