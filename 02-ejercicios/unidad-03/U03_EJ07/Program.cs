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

            int numeroMayor;

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
            if (numero1 > numero2)
            {
                numeroMayor = numero1;
            }
            else
            {
                numeroMayor = numero2;
            }

            if (numero3 > numeroMayor)
            {
                numeroMayor = numero3;
            }

            if (numero4 > numeroMayor)
            {
                numeroMayor = numero4;
            }

            // Mostrar
            Console.WriteLine($"El numero mayor es: {numeroMayor}");
        }
    }

}