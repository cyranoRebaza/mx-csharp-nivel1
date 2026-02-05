using System;

namespace U04_EJ03
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            3. Hacer un programa para ingresar dos números. Si el segundo es distinto de
             cero, calcular la división del primero por el segundo y mostrar el resultado por
             pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
             cero.

             */

            // Declaracion variables
            int numero1;
            int numero2;

            double division;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero2 != 0)
            {
                division = (double)numero1 / numero2;

                Console.WriteLine($"La división es: {division:0.00}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }

            Console.ReadKey();


        }
    }

}