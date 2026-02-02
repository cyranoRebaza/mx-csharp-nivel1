using System;

namespace U03_EJ07
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            7. Hacer un programa para ingresar cuatro números distintos y luego mostrar por
            pantalla el mayor de ellos.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int numero3;
            int numero4;

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

            // Calcular
            if (numero1 < numero2)
            {
                numeroMenor = numero1;
            }
            else
            {
                numeroMenor = numero2;
            }

            if (numero3 < numeroMenor)
            {
                numeroMenor = numero3;
            }

            if (numero4 < numeroMenor)
            {
                numeroMenor = numero4;
            }

            // Mostrar
            Console.WriteLine($"El numero menor es: {numeroMenor}");
        }
    }

}