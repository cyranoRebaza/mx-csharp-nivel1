using System;

namespace U05_EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            12. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
            ningún pedido de datos. USANDO WHILE.
            
             */

            // Declaracion variables
            int interador = 1;

            while (interador <= 10)
            {
                Console.WriteLine(interador);
                interador++;
            }
        }
    }

}