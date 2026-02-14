using System;

namespace U05_EJ22
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            22. Hacer un programa para ingresar una lista de números que corta cuando se
            ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
            números pares, la cantidad de positivos y la cantidad de negativos.
            
             */

            // Declaracion variables
            int numero;

            int cantidadPrimos = 0;
            int cantidadPares = 0;
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                // Positivos
                if (numero > 0)
                {
                    cantidadPositivos++;
                }

                // Negativos
                if (numero < 0)
                {
                    cantidadNegativos++;
                }

                // Pares
                if (numero % 2 == 0)
                {
                    cantidadPares++;
                }

                // Primos
                if (numero > 1)
                {

                    int divisor = 0;
                    int iterador = 2;

                    while (iterador <= numero)
                    {
                        if (numero % iterador == 0)
                        {
                            divisor++;
                        }

                        iterador++;
                    }

                    if (divisor == 1)
                    {
                        cantidadPrimos++;
                    }

                }

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

            }
            // Mostrar resultados
            Console.WriteLine($"cantidad positivos: {cantidadPositivos}");
            Console.WriteLine($"cantidad negativos: {cantidadNegativos}");
            Console.WriteLine($"cantidad pares: {cantidadPares}");
            Console.WriteLine($"cantidad primos: {cantidadPrimos}");
        }
    }

}