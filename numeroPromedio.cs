using System;

namespace PromedioNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo para almacenar los 5 números ingresados
            double[] numeros = new double[5];

            // Solicitamos al usuario que ingrese los 5 números
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1) + ":");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            // Calculamos la suma de los números ingresados
            double suma = 0;
            foreach (double numero in numeros)
            {
                suma += numero;
            }

            // Calculamos el promedio
            double promedio = suma / 5;

            // Mostramos el promedio al usuario
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);

            // Esperamos a que el usuario presione una tecla para cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}