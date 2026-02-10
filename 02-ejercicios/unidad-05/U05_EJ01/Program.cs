using System;

namespace U05_EJ01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. Hacer un programa que solicite el ingreso de 10 números y que muestre el
            mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla. 
            
             */

            // Declaracion variables
            int numero;
            int numeroMayor;

            // Pedir el primer numero e inicializo como mayor de todos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            numeroMayor = numero;

            // Pido el resto de numeros
            for (int i = 0; i < 9; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }

            }

            Console.WriteLine($"El numero mayor es: {numeroMayor}");

            Console.ReadKey();
        }
    }

}