using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string nombreEstudiante;
            string nombreCurso;
 
            Console.Write("Ingrese su nombre: ");
            
            nombreEstudiante = Console.ReadLine();

            Console.Write("Ingrese el nombre del curso: ");

            nombreCurso = Console.ReadLine();
        
            Console.WriteLine("Hola,");
            Console.WriteLine(nombreEstudiante + ", vas muy bien en el curso " + nombreCurso + ".");
            Console.WriteLine("Gracias por su atencion");



            Console.ReadKey();

        }
    }
}

