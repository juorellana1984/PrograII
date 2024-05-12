using System;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entre 0 y 10:");
            int numero = int.Parse(Console.ReadLine());

            // Verificar si el número ingresado está en el rango válido
            if (numero < 0 || numero > 10)
            {
                Console.WriteLine("El número ingresado no está en el rango válido.");
            }
            else
            {
                Console.WriteLine($"Tabla de multiplicar del {numero}:");

                // Iterar a través de los multiplicadores del 1 al 10
                for (int i = 1; i <= 10; i++)
                {
                    // Calcular el resultado de la multiplicación
                    int resultado = numero * i;
                    
                    // Mostrar la multiplicación en formato "4x1=4"
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
            }

            // Esperar a que el usuario presione una tecla para cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}