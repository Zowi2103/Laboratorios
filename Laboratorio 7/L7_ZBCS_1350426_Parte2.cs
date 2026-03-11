using System;
class Program
{
  static void Main()
    {
        int pinbueno = 1234;
        int pin = 0;
        int intentos = 0;
        int maxintentos = 3;

        do
        {
            Console.Write("Ingrese el PIN: ");
            pin = int.Parse(Console.ReadLine());

            if (pin == pinbueno)
            {
                Console.WriteLine("Bienvenido");
                break; 
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            intentos++;

        } while (intentos < maxintentos);

        if (intentos == maxintentos && pin != pinbueno)
        {
            Console.WriteLine("Cuenta bloqueada");
        }
    }
}