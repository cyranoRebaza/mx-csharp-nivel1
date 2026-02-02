using System;
using System.Runtime.InteropServices.Marshalling;

namespace U03_EJ09
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            9. Hacer un programa para ingresar cinco números distintos y luego mostrar por
            pantalla el mayor y el menor de ellos.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int numero5;

            int numeroMayor;
            int numeroMenor;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero4 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero5 = int.Parse(Console.ReadLine());

            // Calcular
            if (numero1 > numero2)
            {
                numeroMayor = numero1;
                numeroMenor = numero2;
            }
            else
            {
                numeroMayor = numero2;
                numeroMenor = numero1;
            }

            if (numero3 > numeroMayor)
            {
                numeroMayor = numero3;
            }
            else
            {
                if (numero3 < numeroMenor)
                {
                    numeroMenor = numero3;
                }
            }

            if (numero4 > numeroMayor)
            {
                numeroMayor = numero4;
            }
            else
            {
                if (numero4 < numeroMenor)
                {
                    numeroMenor = numero4;
                }
            }

            if (numero5 > numeroMayor)
            {
                numeroMayor = numero5;
            }
            else
            {
                if (numero5 < numeroMenor)
                {
                    numeroMenor = numero5;
                }
            }

            // Mostrar
            Console.WriteLine($"El numero mayor es: {numeroMayor}");
            Console.WriteLine($"El numero menor es: {numeroMenor}");
        }
    }

}