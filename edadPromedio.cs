using System;

namespace EdadPromedioEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable para almacenar la suma de las edades
            int sumaEdades = 0;

            // Solicitar al usuario que ingrese las edades de los estudiantes
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"Ingrese la edad del estudiante {i}:");
                int edad = int.Parse(Console.ReadLine());

                // Sumar la edad ingresada a la suma total de edades
                sumaEdades += edad;
            }

            // Calcular el promedio de edades
            double promedioEdades = (double)sumaEdades / 15;

            // Mostrar el resultado
            Console.WriteLine($"La edad promedio de los 15 estudiantes es: {promedioEdades}");

            // Esperar a que el usuario presione una tecla para salir
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}