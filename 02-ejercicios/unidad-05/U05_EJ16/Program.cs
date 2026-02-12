using System;

namespace U05_EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            16. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
            0, 5, 10, 15, 20…. 100. Usando While.
            
             */

            // Declaracion variables
            int iterador = 0;

            const int ITERADOR_LIMITE = 100;

            while (iterador <= ITERADOR_LIMITE)
            {
                Console.WriteLine(iterador);
                iterador += 5;
            }

            Console.ReadKey();
        }
    }

}