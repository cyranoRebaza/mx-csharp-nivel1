using System;

namespace U07_EJ03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            3. Hacer un programa que solicite 100 números enteros y los guarde en un
            vector. Luego recorrer ese vector para calcular el promedio. Mostrar por
            pantalla los valores del vector que son mayores al promedio calculado

             */

            // Declaracion de variables
            int numero;
            int[] numeros = new int[100];


            // Cargar el vector
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine()!);

                numeros[i] = numero;
            }

            // leer el vector y calcular el promedio
            int acumular = 0;
            int contador = 0;
            float promedio = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                acumular += numeros[i];
                contador++;
            }

            promedio = (float)acumular / contador;

            // buscar y mostrar el mayor
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > promedio)
                {
                    Console.WriteLine(numeros[i]);
                }
            }


        }
    }
}
