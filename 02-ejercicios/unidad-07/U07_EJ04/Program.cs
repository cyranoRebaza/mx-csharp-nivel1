using System;

namespace U07_EJ04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            4. Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
            determinar e informar si el vector está ordenado en forma creciente. Por
            ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
            y 9 no lo está.
            
             */

            // Declaraciones
            int numero;
            int[] numeros = new int[10];

            // Cargar vector
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine()!);

                numeros[i] = numero;
            }

            // verificar si esta ordenado forma creciente
            bool ordenado = true; // asumo que el vector esta ordenado

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] <= numeros[i - 1])
                {
                    ordenado = false;
                }

            }

            // mostrar
            if (ordenado)
            {
                Console.WriteLine("Ordenado");
            }
            else
            {
                Console.WriteLine("Desordenado");
            }
        }
    }
}
