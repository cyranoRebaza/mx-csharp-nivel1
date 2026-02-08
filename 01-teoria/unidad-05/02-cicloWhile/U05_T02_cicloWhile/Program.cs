using System;
using System.Diagnostics.Contracts;

namespace U05_T02_cicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            CICLO WHILE

            SINTAXIS:
           
             while(condicion){
                 
                 // codigo                

             }

             */

            Console.WriteLine("--- EJEMPLO 1 ---");

            // EJEMPLO 1: cargar una cantidad indeterminda de numero mientras sea numero sea distinto de cero
            // luego mostrar cuantos fueron
            int numero;
            int contador = 0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                contador++;

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"La cantidad de numeros ingresados es: {contador}");

            Console.WriteLine("--- EJEMPLO 2 ---");

            // EJEMPLO2: mostrar numeros del 1 al 10
            int numero2;
            int cantidadNumeros = 0;

            while (cantidadNumeros < 10)
            {
                cantidadNumeros++;
                Console.WriteLine(cantidadNumeros);
            }



        }
    }

}