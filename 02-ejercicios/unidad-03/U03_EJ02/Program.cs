using System;

namespace U03_EJ02
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            2. 2. Hacer un programa para ingresar dos números distintos y luego se muestre por
   pantalla el menor de ellos.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int menor;

            // Pedir datos
            Console.WriteLine("--- Ingrese numeros distintos ---");
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // Calcular
            if (numero1 < numero2)
            {
                menor = numero1;
            }
            else
            {
                menor = numero2;
            }

            // Mostrar
            Console.WriteLine($"El numero menor es: {menor}");

            Console.ReadKey();

        }
    }

}