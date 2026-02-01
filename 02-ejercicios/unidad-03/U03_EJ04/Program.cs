using System;

namespace U03_EJ04
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            4. Hacer un programa para ingresar un número y luego se emita un cartel por
            pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es
            menor a cero o “Cero” si el número es igual a cero.            
            
             */

            // Declracion variables
            int numero;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            // Calcular
            if (numero == 0)
            {
                Console.WriteLine("Cero");
            }
            else
            {
                if (numero > 0)
                {
                    Console.WriteLine("Positivo");
                }
                else
                {
                    Console.WriteLine("Negativo");
                }
            }

            Console.ReadKey();
        }
    }

}