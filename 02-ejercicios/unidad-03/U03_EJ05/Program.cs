using System;

namespace U03_EJ05
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
           5. Hacer un programa para ingresar un número y mostrar por pantalla un cartel
            aclaratorio si el mismo es PAR o IMPAR.                                                                                                                                                                                                                      aclaratorio si el mismo es PAR o IMPAR.
                        
             */

            // Declaracion variables
            int numero;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
        }
    }

}