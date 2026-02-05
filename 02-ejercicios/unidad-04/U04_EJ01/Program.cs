using System;

namespace U04_EJ01
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1.  Hacer un programa que solicite el ingreso de un número y que luego emita un
            cartel por pantalla aclarando si el mismo es múltiplo de 5.
            
             */

            // Declaracion variables
            int numero;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero % 5 == 0)
            {
                Console.WriteLine($"El numero {numero} es multiplo de 5");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no es multiplo de 5");

            }

            Console.ReadKey();
        }
    }

}