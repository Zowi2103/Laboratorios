using System;
class Program
{
    static void Main()
    {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Clasificacion de vehiculos");

            Console.WriteLine("Ingrese el  número del tipo de su vehículo:");
            Console.WriteLine("1: Bicicleta");
            Console.WriteLine("2: Motocicleta");
            Console.WriteLine("3: Auto");
            Console.WriteLine("4: Camión");
            Console.WriteLine("5: Autobús");

            int vehiculo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (vehiculo)
            {
                case 1:
                    Console.WriteLine("Vehículo: Bicicleta");
                    Console.WriteLine("Clasificación: No motorizado");
                    break;

                case 2:
                    Console.WriteLine("Vehículo: Motocicleta");
                     Console.WriteLine("Clasificación: Ligero");
                    
                    break;

                case 3:
                    Console.WriteLine("Vehículo: Auto");
                    Console.WriteLine("Clasificación: Mediano");
                    break;

                case 4:
                    Console.WriteLine("Vehículo: Camión");
                    Console.WriteLine("Clasificación: Pesado");
                    break;

                case 5:
                    Console.WriteLine("Vehículo: Autobús");
                    Console.WriteLine("Clasificación: Transporte público");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Ingrese un número del 1 al 5.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Programa finalizado. Presione una tecla para salir...");
            Console.ReadKey();

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Bienvenido a Banco Industrial :D");

            Console.Write("Ingrese su límite actual de crédito: Q ");
            double credito = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tipo de su tarjeta (1, 2, 3 u otro número): ");
            int tarjeta = Convert.ToInt32(Console.ReadLine());

            double aumento = 0;

            switch (tarjeta)
        {
            case 1:
                aumento = 0.25;
                break;

            case 2:
                aumento = 0.35;
                break;

            case 3:
                aumento = 0.40;
                break;

            default:
                aumento = 0.50;
                break;
        }

        double naumento = credito * aumento;
        double nuevocredito = credito + naumento;

        Console.WriteLine("Límite actual: Q " + credito);
        Console.WriteLine("Porcentaje de aumento aplicado: " + (aumento * 100) + "%");
        Console.WriteLine("Aumento: Q " + naumento);
        Console.WriteLine("Nuevo límite de crédito: Q " + nuevocredito);

        Console.WriteLine();
        Console.WriteLine("Gracias por usar el sistema.");
        Console.ReadKey();

        Console.WriteLine("Ejercicio 3");
        Console.WriteLine("Evaluacion de empleados");

        Console.Write("Ingrese su puntuación (0.0, 0.4, 0.6 o más): ");
        double puntuacion = Convert.ToDouble(Console.ReadLine());

        if (puntuacion != 0.0 && puntuacion != 0.4 && puntuacion < 0.6)
        {
            Console.WriteLine("Error: Puntuación no válida.");
            Console.WriteLine("Solo se permiten: 0.0, 0.4 o 0.6 en adelante.");
            Console.ReadKey();
            return;
        }

        int puntos = (int)(puntuacion * 10);

        string nivel = "";
        double incentivo = 0;

        switch (puntos)
        {
            case 0:
                nivel = "Inaceptable";
                break;

            case 4:
                nivel = "Aceptable";
                break;

            default:
                nivel = "Meritorio";
                break;
        }

        incentivo = 2400 * puntuacion;

        Console.WriteLine();
        Console.WriteLine("Resultados");
        Console.WriteLine("Rendimiento: " + nivel);
        Console.WriteLine("Cantidad de dinero a recibir: € " + incentivo);

        Console.WriteLine();
        Console.WriteLine("Fin del programa.");
        Console.ReadKey();

        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Bienvenido a Pizzeria Bella Napoli");

        Console.Write("¿Desea una pizza vegetariana? (si/no): ");
        string tipo = Console.ReadLine().ToLower();

        string ingredienteExtra = "";
        string tipoPizza = "";

        if (tipo == "si")
        {
            tipoPizza = "Vegetariana";

            Console.WriteLine("\nIngredientes disponibles:");
            Console.WriteLine("1. Pimiento");
            Console.WriteLine("2. Tofu");

            Console.Write("Elija un ingrediente (1 o 2): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ingredienteExtra = "Pimiento";
                    break;

                case 2:
                    ingredienteExtra = "Tofu";
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    return;
            }
        }
        else if (tipo == "no")
        {
            tipoPizza = "No Vegetariana";

            Console.WriteLine("\nIngredientes disponibles:");
            Console.WriteLine("1. Peperoni");
            Console.WriteLine("2. Jamón");
            Console.WriteLine("3. Salmón");

            Console.Write("Elija un ingrediente (1, 2 o 3): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ingredienteExtra = "Peperoni";
                    break;

                case 2:
                    ingredienteExtra = "Jamón";
                    break;

                case 3:
                    ingredienteExtra = "Salmón";
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    return;
            }
        }
        else
        {
            Console.WriteLine("Debe responder 'si' o 'no'.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Pedido:");
        Console.WriteLine("Tipo de pizza: " + tipoPizza);
        Console.WriteLine("Ingredientes:");
        Console.WriteLine("- Mozzarella");
        Console.WriteLine("- Tomate");
        Console.WriteLine("- " + ingredienteExtra);

        Console.WriteLine("\nGracias por su compra.");
        Console.ReadKey();
    }
    }
