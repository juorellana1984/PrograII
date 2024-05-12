using System;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la variable para almacenar la suma
            int suma = 0;

            // Iteramos hasta que se ingrese un número negativo o cero
            while (true)
            {
                // Pedimos al usuario que ingrese un número
                Console.WriteLine("Por favor, ingresa un número positivo (ingresa un número negativo o cero para terminar):");
                int numero = int.Parse(Console.ReadLine());

                // Verificamos si el número ingresado es negativo o cero
                if (numero <= 0)
                {
                    break; // Salimos del bucle while
                }

                // Sumamos el número al total
                suma += numero;
            }

            // Mostramos la suma total al usuario
            Console.WriteLine("La suma de los números positivos ingresados es: " + suma);

            // Esperamos a que el usuario presione una tecla para cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}