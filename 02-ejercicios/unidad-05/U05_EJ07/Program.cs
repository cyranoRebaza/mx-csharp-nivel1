using System;

namespace U05_EJ07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el
            máximo de ellos y la posición en la que fue ingresado.
            
             */

            // Declaracion variables
            int numero;
            int maximo = 0;
            int posicionMaximo = 0;

            // Pedir datos y buscar el mayor
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 0 || numero > maximo)
                {
                    maximo = numero;
                    posicionMaximo = i + 1;
                }

            }

            // Mostrar numero mayor y su posicion
            Console.WriteLine($"numero mayor es: {maximo}");
            Console.WriteLine($"posicion numero mayor es: {posicionMaximo}");

            Console.ReadKey();
        }
    }

}