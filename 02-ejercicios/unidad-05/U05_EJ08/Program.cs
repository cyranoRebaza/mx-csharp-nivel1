using System;

namespace U05_EJ08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el
            menor de ellos y la posición en la que fue encontrado.
            
             */

            // Declaracion variables
            int numero;
            int minimo = 0;
            int posicionMinimo = 0;

            // Pedir datos y buscar el menor
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 0 || numero < minimo)
                {
                    minimo = numero;
                    posicionMinimo = i + 1;
                }
            }

            // Mostrar resultados
            Console.WriteLine($"numero menor: {minimo}");
            Console.WriteLine($"posicion numero menor: {posicionMinimo}");

            Console.ReadKey();


        }
    }

}