using System;

namespace U06_EJ07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            7. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            
             */

            // Declaracion variables
            int numero;
            int cantidadNumeros;
            int numeroGrupo = 0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                cantidadNumeros = 0;
                numeroGrupo++;

                while (numero > 0)
                {
                    cantidadNumeros++;

                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"grupo # {numeroGrupo} tiene cantidad de {cantidadNumeros} numeros");

                if (numero == 0)
                {
                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }
            }


        }
    }

}