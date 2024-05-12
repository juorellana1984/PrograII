using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números impares entre 0 y 100:");

            // Iterar a través de los números del 0 al 100
            for (int i = 0; i <= 100; i++)
            {
                // Verificar si el número es impar
                if (i % 2 != 0)
                {
                    // Mostrar el número impar
                    Console.WriteLine(i);
                }
            }

            // Esperar a que el usuario presione una tecla para cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}