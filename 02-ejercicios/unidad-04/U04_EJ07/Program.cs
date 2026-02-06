using System;

namespace U04_EJ07
{


    class Program
    {
        static void Main(string[] args)
        {
            /* 
            7.  Hacer un programa para ingresar 4 números. Luego analizar e informar por
            pantalla si los mismos se encuentran ordenados de forma decreciente.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero4 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero1 > numero2 && numero2 > numero3 && numero3 > numero4)
            {
                Console.WriteLine("Los numeros se encuentran ordenados de forma decreciente");
            }
            else
            {
                Console.WriteLine("Los numeros no se encuentran ordenados de forma decreciente");
            }
        }
    }

}