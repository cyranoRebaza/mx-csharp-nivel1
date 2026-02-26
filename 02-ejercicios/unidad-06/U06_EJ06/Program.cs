using System;

namespace U06_EJ06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            6. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            
             */

            // Declaracion variables
            int numero;
            int cantidadDivisores;
            int cantidadPrimos = 0;

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 1)
                {
                    cantidadDivisores = 0;

                    for (int j = 1; j <= numero; j++)
                    {
                        if (numero % j == 0)
                        {
                            cantidadDivisores++;
                        }
                    }

                    if (cantidadDivisores == 2)
                    {
                        cantidadPrimos++;
                    }
                }
            }

            Console.WriteLine($"La cantidad de numeros primos es: {cantidadPrimos}");
        }
    }

}