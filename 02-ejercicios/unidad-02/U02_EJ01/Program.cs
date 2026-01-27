using System;

namespace U02_EJ01
{


    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1.Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int suma;

            // Pedir los datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // Calcular la suma
            suma = numero1 + numero2;

            // Mostrar
            Console.WriteLine($"la suma es: {suma}");

            Console.ReadKey();
        }
    }

}