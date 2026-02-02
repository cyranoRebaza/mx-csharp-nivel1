using System;

namespace U03_EJ10
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            10. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
            cuáles son mayores a 100.
            
             */

            //  Declaracion variables
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            const int limiteNumero = 100;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero4 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (numero1 > limiteNumero)
            {
                Console.WriteLine(numero1);
            }
            if (numero2 > limiteNumero)
            {
                Console.WriteLine(numero2);
            }
            if (numero3 > limiteNumero)
            {
                Console.WriteLine(numero3);
            }
            if (numero4 > limiteNumero)
            {
                Console.WriteLine(numero4);
            }
        }
    }

}