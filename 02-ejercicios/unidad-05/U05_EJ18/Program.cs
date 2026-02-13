using System;

namespace U05_EJ18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            18. Hacer un programa que solicite una lista de números que corta cuando se
            ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
            en la que fue ingresado.
            
             */

            // Declaracion variables
            int numero;
            int numeroMaximo = 0;
            int posicionMaximo = 0;
            int posicion = 1;


            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeroMaximo = numero;
                posicionMaximo = posicion;

                while (numero != 0)
                {
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                        posicionMaximo = posicion;
                    }


                    posicion++;

                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }

                // Mostrar resultado
                Console.WriteLine($"El numero maximo es: {numeroMaximo}");
                Console.WriteLine($"La posicion maxima es: {posicionMaximo}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros");
            }
        }
    }

}