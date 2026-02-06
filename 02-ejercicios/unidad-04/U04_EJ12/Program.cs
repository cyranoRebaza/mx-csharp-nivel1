using System;

namespace U04_EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            12. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si
            la suma de los dos primeros es mayor al producto del segundo con el tercero.
            
             */

            //  Declaracion variables
            int numero1;
            int numero2;
            int numero3;

            int suma = 0;
            int producto = 0;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero3 = int.Parse(Console.ReadLine());

            // Calcular
            suma = numero1 + numero2;
            producto = numero2 * numero3;

            if (suma > producto)
            {
                Console.WriteLine("La suma es mayor que el producto");
            }

            Console.ReadKey();

        }
    }

}