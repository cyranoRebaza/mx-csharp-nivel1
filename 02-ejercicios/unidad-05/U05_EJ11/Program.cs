using System;

namespace U05_EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            11. Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
            de los primos de la lista. En caso de no haber ningún número primo, deberá
            aclararlo con un cartel.
            
             */

            // Declaracion variables
            int numero;

            int mayorPrimo = 0;
            bool hayPrimo = false;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                // buscar primo
                bool esPrimo = true;

                if (numero <= 1)
                {
                    esPrimo = false;
                }
                else
                {
                    // busco divisores desde 2 hasta la raiz del numero
                    for (int divisor = 2; divisor * divisor <= numero; divisor++)
                    {
                        if (numero % divisor == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                }

                // buscar el mayor de los primos
                if (esPrimo)
                {
                    if (!hayPrimo || numero > mayorPrimo)
                    {
                        mayorPrimo = numero;
                        hayPrimo = true;
                    }
                }


            }

            // Mostrar resultado
            if (hayPrimo)
            {
                Console.WriteLine($"El mayor de los numeros primos es: {mayorPrimo}");

            }
            else
            {
                Console.WriteLine("No hay primos");
            }

            Console.ReadKey();
        }
    }

}