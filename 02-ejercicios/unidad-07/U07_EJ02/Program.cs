using System;

namespace U07_EJ02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            2. Hacer un programa que solicite 50 números enteros y los guarde en un vector.
            Luego recorrer todos los elementos del vector y determinar cuál es el valor
            máximo y su posición dentro del vector.
             */

            // Declaracion
            int numero;
            int[] numeros = new int[50];

            int maximo = 0;
            int posicionMaximo = 0;

            // Cargar el vector
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine()!);

                numeros[i] = numero;
            }

            // calcular el valor maximo y posicion
            maximo = numeros[0];
            posicionMaximo = 1;

            for (int i = 1; i < numeros.Length; i++) // recorre desde segundo elemento
            {

                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    posicionMaximo = i + 1;
                }

            }

            // Mostrar
            Console.WriteLine($"El valor maximo es: {maximo}");
            Console.WriteLine($"La posicion del valor maximo es: {posicionMaximo}");
        }
    }
}
