using System;

namespace U04_EJ06
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            6.  Hacer un programa para ingresar por teclado la longitud de los tres lados de un
            triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
            de triángulo corresponde:

            a. Equilátero: cuando los tres lados sean iguales.
            b. Isósceles: cuando dos de los tres lados sean iguales.
            c. Escaleno: cuando todos los lados sean distintos.
            
             */

            // Declaracion variables
            int ladoTriangulo1;
            int ladoTriangulo2;
            int ladoTriangulo3;

            // Pedir datos
            Console.Write("Ingrese el lado 1 del triangulo: ");
            ladoTriangulo1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2 del triangulo: ");
            ladoTriangulo2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 3 del triangulo: ");
            ladoTriangulo3 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (ladoTriangulo1 == ladoTriangulo2 && ladoTriangulo1 == ladoTriangulo3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else if (ladoTriangulo1 != ladoTriangulo2 && ladoTriangulo2 != ladoTriangulo3 && ladoTriangulo1 != ladoTriangulo3)
            {
                Console.WriteLine("Es un triangulo escaleno");
            }
            else
            {
                Console.WriteLine("Es un triangulo isoseles");
            }

            Console.ReadKey();
        }
    }

}