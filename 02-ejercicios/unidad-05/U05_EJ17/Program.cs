using System;

namespace U05_EJ17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            17. Hacer un programa que solicite UN número y luego calcule y emita un cartel
            aclaratorio si el mismo es primo o no es primo.

             */

            // Declaracion variables
            int numero;
            int divisor = 2;

            bool esPrimo = true;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                esPrimo = false;
            }
            else
            {

                // buscar divisores del 2 hasta la raiz del numero
                while (divisor * divisor <= numero)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                    divisor++;
                }

            }

            if (esPrimo)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("NO es primo");
            }

            Console.ReadKey();
        }
    }

}