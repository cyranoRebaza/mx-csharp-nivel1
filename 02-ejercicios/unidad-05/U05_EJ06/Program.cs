using System;

namespace U05_EJ06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            6. Hacer un programa que solicite UN número y luego calcule y emita un cartel
            aclaratorio si el mismo es primo o no es primo.

            Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            
             */

            //  Declaracion variables
            int numero;
            bool esPrimo = true;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            // validar y verificar si el numero es primo
            if (numero <= 1)
            {
                esPrimo = false;
            }
            else
            {
                // buscar divisores hasta la raiz del numero
                for (int divisor = 2; divisor * divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            // Mostrar resultado
            if (esPrimo)
            {
                Console.WriteLine("ES PRIMO");
            }
            else
            {
                Console.WriteLine("NO ES PRIMO");
            }

            Console.ReadKey();

        }
    }

}