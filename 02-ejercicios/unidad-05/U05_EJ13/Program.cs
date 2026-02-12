using System;

namespace U05_EJ13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            13. Hacer un programa para mostrar los números del 10 al 1. No se debe realizar
            ningún pedido de datos. USANDO WHILE.
            
             */

            // Declaracion de variables
            int iterador = 10;

            while (iterador >= 1)
            {
                Console.WriteLine(iterador);
                iterador--;
            }

            Console.ReadKey();
        }
    }

}