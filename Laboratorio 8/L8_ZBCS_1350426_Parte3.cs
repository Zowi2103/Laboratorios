using System;
class Program
{
    static void Main()
    {
        int opcion;
        double totalVentas = 0;
        int clientes = 0;

        do
        {
            Console.WriteLine("1 Registrar compra");
            Console.WriteLine("2 Mostrar total de ventas");
            Console.WriteLine("3 Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4 Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el monto de la compra: ");
                    double monto = Convert.ToDouble(Console.ReadLine());

                    totalVentas += monto;
                    clientes++;

                    Console.WriteLine("Compra registrada.");
                    break;

                case 2:
                    Console.WriteLine("Total de ventas del día: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Clientes atendidos: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }
}
