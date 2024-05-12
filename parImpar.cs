using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número
            Console.WriteLine("Por favor, ingresa un número:");
            
            // Lee la entrada del usuario y la convierte en un número entero
            int numero = int.Parse(Console.ReadLine());
            
            // Comprueba si el número es par o impar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }

            // Espera a que el usuario presione una tecla para salir
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}