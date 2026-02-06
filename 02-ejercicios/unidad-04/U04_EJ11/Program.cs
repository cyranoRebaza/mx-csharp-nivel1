using System;

namespace U04_EJ11
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            11. Hacer un programa para ingresar tres números y luego mostrarlos ordenados
            de menor a mayor.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int numero3;

            int menor = 0;
            int medio = 0;
            int mayor = 0;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero3 = int.Parse(Console.ReadLine());

            // Calcular 
            if (numero1 <= numero2 && numero1 <= numero3)
            {
                menor = numero1;

                if (numero2 <= numero3)
                {
                    medio = numero2;
                    mayor = numero3;
                }
                else
                {
                    medio = numero3;
                    mayor = numero2;
                }
            }
            else if (numero2 <= numero1 && numero2 <= numero3)
            {
                menor = numero2;

                if (numero1 <= numero3)
                {
                    medio = numero1;
                    mayor = numero3;
                }
                else
                {
                    medio = numero3;
                    mayor = numero1;
                }
            }
            else
            {
                menor = numero3;

                if (numero1 <= numero2)
                {
                    medio = numero1;
                    mayor = numero2;
                }
                else
                {
                    medio = numero2;
                    mayor = numero1;
                }
            }

            // Mostrar
            Console.WriteLine($"menor: {menor}");
            Console.WriteLine($"medio: {medio}");
            Console.WriteLine($"mayor: {mayor}");

            Console.ReadKey();

        }
    }

}