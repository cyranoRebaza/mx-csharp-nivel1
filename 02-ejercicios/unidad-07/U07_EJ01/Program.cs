using System;

namespace U07_EJ01
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
            1. Hacer un programa que solicite 50 números enteros y los guarde en un vector.
            Luego recorrer el vector y determinar e informar cuál es la suma de los valores
            del mismo.
            Nota: usar dos ciclos: uno para guardar los números en el vector y otro para
            recorrerlo y leerlo.
             */

            // Declaraciones
            int numero;
            int[] numeros = new int[50];

            // Cargar el vector
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine()!);

                numeros[i] = numero;

            }

            // leer y acumular
            int sumaValores = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sumaValores += numeros[i];
            }

            // mostrar
            Console.WriteLine($"La suma de los valores es: {sumaValores}");
        }
    }
}
