using System;
namespace U03_T02_acumularContar
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
                ACUMULADORES Y CONTADORES
                - son variables que por lo general se inicializan en cero
                
             */

            // Contadores

            // Ejemplo 1:

            int contador = 0;
            contador = contador + 1;
            contador = contador + 1;
            contador = contador + 1;
            contador = contador + 1;
            contador = contador + 1;

            Console.WriteLine($"El conteo es: {contador}"); // salida : 5

            // Ejemplo 2: contar los numeros mayores a 18, acumular los mismos y calcular el promedio
            int numero1 = 20;
            int numero2 = 30;
            int numero3 = 15;

            int cantidadNumeros = 0;
            int acumuladorNumeros = 0;
            double promedioNumeros;

            if (numero1 > 18)
            {
                cantidadNumeros = cantidadNumeros + 1;
                acumuladorNumeros += numero1;
            }

            if (numero2 > 18)
            {
                cantidadNumeros++;
                acumuladorNumeros += numero2;
            }

            if (numero3 > 18)
            {
                cantidadNumeros += 1;
                acumuladorNumeros += numero3;
            }

            promedioNumeros = (double)acumuladorNumeros / cantidadNumeros;

            Console.WriteLine($"La cantidad de numeros es: {cantidadNumeros}");
            Console.WriteLine($"La suma de los numeros es: {acumuladorNumeros}");
            Console.WriteLine($"El promedio de los numeros es: {promedioNumeros:0.00} %");

        }
    }

}