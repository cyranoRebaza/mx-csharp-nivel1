using System;

namespace U03_EJ03
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            3.  Hacer un programa para ingresar dos números y que luego emita por pantalla
            el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.
            Nota: los números pueden ser iguales.            
            
             */

            // Declaracion variables
            int numero1;
            int numero2;

            int numeroMayor;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero1 == numero2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"El mayor es: {numero1}");
                }
                else
                {
                    Console.WriteLine($"El mayor es: {numero2}");
                }
            }

            Console.ReadKey();

        }
    }

}