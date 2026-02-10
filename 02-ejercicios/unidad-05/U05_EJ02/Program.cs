using System;
using System.Runtime.InteropServices.Marshalling;

namespace U05_EJ02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            2. Hacer un programa que solicite 20 números y calcule y emita por pantalla
            cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el
            conteo final.
            
             */

            // Declaracion variables
            int numero;
            int contadorPositivos = 0;

            // pedir datos
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    contadorPositivos++;
                }
            }

            // mostrar
            Console.WriteLine($"La cantidad de numeros positivos es {contadorPositivos}");

            Console.ReadKey();
        }
    }

}