using System;

namespace CuadradoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable para almacenar el número ingresado
            double numero;

            // Ciclo para solicitar al usuario que ingrese un número mayor que cero
            do
            {
                Console.WriteLine("Ingrese un número mayor que cero:");
                
                // Intenta convertir la entrada del usuario en un número
                // Si la entrada no es válida, se generará una excepción
                try
                {
                    numero = double.Parse(Console.ReadLine());
                    
                    // Si el número es menor o igual a cero, muestra un mensaje de error
                    if (numero <= 0)
                    {
                        Console.WriteLine("ERROR. Reingresar número.");
                    }
                }
                catch (FormatException)
                {
                    // Si la entrada no es un número válido, muestra un mensaje de error
                    Console.WriteLine("ERROR. Reingresar número.");
                    numero = -1; // Asigna un valor negativo para continuar el ciclo
                }
            } while (numero <= 0); // Continúa el ciclo mientras el número sea menor o igual a cero
            
            // Calcula el cuadrado del número ingresado
            double cuadrado = numero * numero;
            
            // Muestra el resultado
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");

            // Espera a que el usuario presione una tecla para salir
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}