using System;

namespace U03_EJ11
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            11. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
            cuántos son menores a 100.
            
             */

            //  Declaracion variables
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            const int limiteNumero = 100;
            int contador = 0;



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
            if (numero1 < limiteNumero)
            {
                contador++;
            }
            if (numero2 < limiteNumero)
            {
                contador++;
            }
            if (numero3 < limiteNumero)
            {
                contador++;
            }
            if (numero4 < limiteNumero)
            {
                contador++;
            }

            // Mostrar
            Console.WriteLine($"La cantidad de numeros menores a 100 son: {contador}");
        }
    }

}