using System;
using System.Globalization;

namespace U05_EJ09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            9. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
            de aquellas personas mayores a 18 años.
            
             */

            // Declaracion variables
            int edad;
            int contadorEdades = 0;
            int sumaEdades = 0;

            const int LIMITE_EDAD = 18;
            double promedioEdades;
            // Ingresar datos
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= LIMITE_EDAD)
                {
                    contadorEdades++;
                    sumaEdades += edad;
                }
            }

            // Calcular y mostrar el promedio de edades
            if (contadorEdades > 0)
            {
                promedioEdades = (double)sumaEdades / contadorEdades;
                Console.WriteLine($"El promedio de edades es: {promedioEdades}");
            }
            else
            {
                Console.WriteLine("no hay personas mayores a 18 anios");
            }

            Console.ReadKey();

        }
    }

}