using System;

namespace U04_EJ02
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            2.  Hacer un programa que solicite el ingreso de dos números y luego calcular:

            a. La resta si el primero es mayor que el segundo.
            b. La suma si son iguales.
            c. El producto si el primero es menor.

            Se deberá emitir un cartel por pantalla con el resultado correspondiente           
            
             */

            // Declaracion variables
            int numero1;
            int numero2;

            int resultado;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero1 > numero2)
            {
                resultado = numero1 - numero2;
            }
            else if (numero1 == numero2)
            {
                resultado = numero1 + numero2;
            }
            else
            {
                resultado = numero1 * numero2;
            }

            // Mostrar
            Console.WriteLine($"El resultado es: {resultado}");

            Console.ReadKey();


        }
    }

}