using System;

namespace U05_EJ05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
            0, 5, 10, 15, 20…. 100.
            
             */

            // Mostrar los numeros de 0 a 100 de 5 en 5
            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }

}