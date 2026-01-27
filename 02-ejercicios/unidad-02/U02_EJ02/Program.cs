using System;

namespace U02_EJ02
{


    class Program
    {
        static void Main(string[] args)
        {
            /* 
            2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            
             */

            // Declarar las variables
            int numero;
            int numeroCubo;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            // Calcular
            numeroCubo = numero * numero * numero;

            // Mostrar
            Console.WriteLine($"El numero {numero} elevado al cubo es: {numeroCubo}");

            Console.ReadKey();
        }
    }

}