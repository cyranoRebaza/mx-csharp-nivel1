using System;

namespace U04_EJ10
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            10. Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
            son todos iguales entre sí, caso contrario, no emitir nada.

             */

            // Declaracion varibles
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            numero4 = int.Parse(Console.ReadLine());

            // Calcular
            if (numero1 == numero2 && numero1 == numero3 && numero1 == numero4)
            {
                Console.WriteLine("Los cuatro numeros son iguales");
            }

            Console.ReadKey();

        }
    }

}