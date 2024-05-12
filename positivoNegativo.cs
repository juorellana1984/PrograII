using System;

namespace PositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número
            Console.WriteLine("Por favor, ingresa un número:");
            
            // Lee la entrada del usuario y la convierte en un número
            double numero = double.Parse(Console.ReadLine());
            
            // Comprueba si el número es positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine("El número ingresado es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número ingresado es negativo.");
            }
            else
            {
                Console.WriteLine("El número ingresado es cero.");
            }

            // Espera a que el usuario presione una tecla para salir
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}