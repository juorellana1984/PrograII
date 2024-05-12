using System;

namespace SueldoMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglos para almacenar los nombres y sueldos de los operarios
            string[] nombres = new string[5];
            double[] sueldos = new double[5];

            // Solicitamos al usuario que ingrese los nombres y sueldos de los operarios
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del operario " + (i + 1) + ":");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo del operario " + (i + 1) + ":");
                sueldos[i] = double.Parse(Console.ReadLine());
            }

            // Encontramos el sueldo mayor y su índice correspondiente
            double sueldoMayor = sueldos[0];
            int indiceSueldoMayor = 0;

            for (int i = 1; i < 5; i++)
            {
                if (sueldos[i] > sueldoMayor)
                {
                    sueldoMayor = sueldos[i];
                    indiceSueldoMayor = i;
                }
            }

            // Mostramos el nombre del operario con el sueldo mayor
            Console.WriteLine("El operario con el sueldo mayor es:");
            Console.WriteLine("Nombre: " + nombres[indiceSueldoMayor]);
            Console.WriteLine("Sueldo: " + sueldos[indiceSueldoMayor]);

            // Esperamos a que el usuario presione una tecla para cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}