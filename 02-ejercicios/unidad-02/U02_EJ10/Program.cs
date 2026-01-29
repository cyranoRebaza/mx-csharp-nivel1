using System;

namespace U02_EJ10
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            10. Hacer un programa que permita ingresar por teclado dos números y que luego muestre por pantalla 
            la suma, la resta, la multiplicación y la división de dichos números. Se deben mostrar cuatro 
            resultados en pantalla. Los números deben ser solicitados una única vez.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;

            int suma;
            int resta;
            int multiplicacion;
            double division;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // Calcular
            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multiplicacion = numero1 * numero2;
            division = (double)numero1 / numero2;

            // Mostrar
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicacion: {multiplicacion}");
            Console.WriteLine($"Division: {division:0.00}");

            Console.ReadKey();
        }
    }

}