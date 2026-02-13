using System;

namespace U05_EJ21
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            21. Hacer un programa que solicite una lista de números que corta cuando se
            ingresa un cero y luego emitir por pantalla el máximo de los números
            negativos y el mínimo de los números positivos.

             */

            // Declaracion variables
            int numero;
            int minimoPositivos = 0;
            int maximoNegativos = 0;

            bool hayPositivo = false;
            bool hayNegativos = false;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {

                if (numero > 0)
                {
                    // buscar el minimo de los positivos
                    if (!hayPositivo)
                    {
                        minimoPositivos = numero;
                        hayPositivo = true;
                    }
                    else
                    {
                        if (numero < minimoPositivos)
                        {
                            minimoPositivos = numero;
                        }
                    }

                }
                else
                {
                    // buscar el maximo de los negativos
                    if (!hayNegativos)
                    {
                        maximoNegativos = numero;
                        hayNegativos = true;
                    }
                    else
                    {
                        if (numero > maximoNegativos)
                        {
                            maximoNegativos = numero;
                        }
                    }
                }

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Mostrar resultados
            if (hayPositivo)
            {
                Console.WriteLine($"El minimo de los positivos es: {minimoPositivos}");

            }
            else
            {
                Console.WriteLine("No se ingresaron numeros positivos");
            }

            if (hayNegativos)
            {
                Console.WriteLine($"El maximo de los negativos es: {maximoNegativos}");

            }
            else
            {
                Console.WriteLine("No se ingresaron numeros negativos");
            }

            Console.ReadKey();
        }
    }

}