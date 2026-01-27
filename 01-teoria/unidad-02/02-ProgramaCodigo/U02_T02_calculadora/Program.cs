using System;

namespace U02_T02_calculadora
{

    class Program
    {
        static void Main(string[] args)
        {

            // paso 0: Declaracion variables
            int numero1;
            int numero2;

            int resultado;

            // paso 1: Pedir valor
            Console.WriteLine("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // paso 2: Realizar calculo
            resultado = numero1 + numero2;

            // paso 3: Mostrar respuesta
            Console.WriteLine($"El resultado de la suma es: {resultado}");

        }
    }
}
