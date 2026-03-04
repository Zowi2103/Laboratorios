using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("EJERCICIO 1");
        Console.Write("Ingrese el modelo de la nave:");
        string modelo = Console.ReadLine();

        Console.Write("Ingrese la capacidad de carga:");
        int capacidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el nivel de combustible:");
        float combustible = float.Parse(Console.ReadLine());

        Console.Write("El motor está activo? (true/false):");
        bool motor = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("DATOS DE LA NAVE:");
        Console.WriteLine("Modelo: " + modelo +
                          " | Capacidad: " + capacidad  +
                          " | Combustible: " + combustible +
                          " | Motor de salto: " + motor);

        Console.WriteLine("EJERCICIO 2");
        short sensoresActivos = 128;
        int registroProcesador;
        registroProcesador = sensoresActivos;
        double precisionTotal = registroProcesador;

        Console.WriteLine("Precisión total: " + precisionTotal);

        Console.WriteLine("EJERCICIO 3");
        double energiaGenerada = 987.65;
        int energiaLimitada;
        energiaLimitada = (int)energiaGenerada;

        Console.WriteLine("Energía generada: " + energiaGenerada);
        Console.WriteLine("Energía limitada: " + energiaLimitada);

        Console.WriteLine("EJERCICIO 4");
        Console.Write("Ingrese la distancia al planeta más cercano: ");

        string entradaRadar = Console.ReadLine();
        int distancia = int.Parse(entradaRadar);
        int distanciaSegura = distancia + 100;

        Console.WriteLine("Distancia segura: " + distanciaSegura);

        Console.WriteLine("EJERCICIO 5");
        string señalOxigeno = "true";
        bool oxigenoActivo = Convert.ToBoolean(señalOxigeno);
        string temperaturaCabina = "22.8";
        double temperatura = Convert.ToDouble(temperaturaCabina);

        Console.WriteLine("Estado del oxígeno: " + oxigenoActivo);
        Console.WriteLine("Temperatura de la cabina: " + temperatura);


        Console.WriteLine("EJERCICIO 6");
        double velocidadLuz = 299792.458;
        string velocidadS = velocidadLuz.ToString();
        string velocidadN= velocidadLuz.ToString("N3");

        Console.WriteLine("Velocidad de la luz (normal): " + velocidadS);
        Console.WriteLine("Velocidad de la luz (separado): " + velocidadN);

        Console.WriteLine("EJERCICIO 7");
        Console.Write("Ingrese el precio por galón de Litio: ");

        string precioN = Console.ReadLine();
        double precio = Convert.ToDouble(precioN);
        double impuesto = precio * 0.12;
        double costoTotal = precio + impuesto;
        int costoFinal = (int)costoTotal;

        Console.WriteLine("El costo final de suministro es: " + costoFinal);

        Console.WriteLine("EJERCICIO 8");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⡾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣿⡿⠟⢀⣀⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡼⠟⠛⠛⠓⠙⠚⢡⣀⣀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠋⠀⠀⠀⠀⠀⠀⠀⠀⢫⣍⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡆⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢀⡶⠛⣶⡼⠃⠀⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣇⡀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣾⠀⣀⣿⠀⠀⠘⠋⠀⣀⠀⠀⠀⠀⠀⠀⣠⡿⠙⣽⣷⣦⡀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⣿⣿⣿⣿⣧⡀⠀⠀⠈⠛⠃⠀⢾⠇⠀⠰⠾⠁⠀⠈⠻⢿⣿⡀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⡳⡤⢀⡀⠀⠀⠀⠀⠀⣶⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣶⣬⣽⣿⣶⣶⣶⣟⠙⠳⣦⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⣰⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⣠⠟⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⢰⡏⠉⠉⠉⠉⠉⠛⠛⠻⠿⣽⣿⣿⣿⡛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⡀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⢠⡟⠉⠀⠀⠀⢰⡶⣤⣄⣀⣀⣀⣀⣀⠀⠀⠈⠉⠳⣆⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠛⠛⠒⠒⠒⠒⠛⠛⠀⠈⠉⠉⠉⠙⠓⠒⠲⠶⠖⠒⠓⠀⠀⠀⠀⠀⠀⠀⠀");

        Console.Write("\n¿Qué te gustaría o qué harás el 14 de febrero? ");
        string respuesta = Console.ReadLine();

        Console.WriteLine("\nMensaje de misión registrado:");
        Console.WriteLine(respuesta);

        Console.WriteLine("\nEl 14 de febrero fui a ver Marty Supreme al cine");
    }
}
