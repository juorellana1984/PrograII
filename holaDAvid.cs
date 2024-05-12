using System;

namespace SaludoNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese su nombre
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();

            // Comprobar si el nombre es "David" y saludar en consecuencia
            if (nombre.ToLower() == "david")
            {
                Console.WriteLine("¡Hola, David!");
            }
            else
            {
                Console.WriteLine("No te conozco.");
            }

            // Esperar a que el usuario presione una tecla para cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}