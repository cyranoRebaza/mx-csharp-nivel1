using System;

namespace U05_T03_cicloDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLO DO WHILE
            // EJEMPLO 1: Mostrrar la cantidad de numeros ingresados,cortar con cero
            int numero;
            int contador = 0;

            do
            {

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    contador++;
                }


            } while (numero != 0);

            Console.WriteLine($"Ingresaste {contador} numeros");
        }
    }

}