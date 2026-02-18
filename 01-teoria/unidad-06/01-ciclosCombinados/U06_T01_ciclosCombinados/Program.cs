using System;
using System.Security.Cryptography;

namespace U06_T01_ciclosCombinados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                CICLOS COMBINADOS O ANIDADOS
                - FOR CON FOR
                - FOR CON WHILE
                - WHILE CON FOR
                - WHILE CON WHILE
            
             */

            // Ejemplo 1: Calcular y mostrar el promedio de edades de 5 equipos de futbol.
            // cada equipo tiene 20 jugadores

            // for con for
            double promedioEdades;
            int edad;
            int sumaEdades;

            for (int x = 0; x < 5; x++)
            {
                sumaEdades = 0;

                for (int y = 0; y < 20; y++)
                {
                    Console.Write("Ingrese la edad:");
                    edad = int.Parse(Console.ReadLine());

                    sumaEdades += edad;

                }

                promedioEdades = (double)sumaEdades / 20;
                Console.WriteLine($"El promedio de edades es: {promedioEdades}");
            }

            Console.WriteLine("-------------------------------------------");

            // Ejemplo 2: Calcular y mostrar el promedio de edades de 5 equipos de futbol.
            // no se cuantos integrantes tiene cada equipo


            // for con while
            double promedioEdades2;
            int edad2;
            int sumaEdades2;
            int cantidadEdades2;

            for (int x = 0; x < 5; x++)
            {
                sumaEdades2 = 0;
                cantidadEdades2 = 0;

                Console.Write("Ingrese la edad: ");
                edad2 = int.Parse(Console.ReadLine());

                while (edad2 != 0)
                {
                    sumaEdades2 += edad2;
                    cantidadEdades2++;

                    Console.Write("Ingrese la edad: ");
                    edad2 = int.Parse(Console.ReadLine());
                }

                promedioEdades2 = sumaEdades2 / cantidadEdades2;
                Console.WriteLine($"El promedio de edades es: {promedioEdades2}");
            }

            Console.WriteLine("-------------------------------------------");

            // Ejemplo 3: Calcular y mostrar el promedio de edades de varios equipos de futbol.
            // cada equipo tiene 20 jugadores

            // while con for
            double promedioEdades3;
            int edad3;
            int sumaEdades3;

            Console.Write("Ingrese 1 para comenzar a procesar o 0 para terminar:");
            edad3 = int.Parse(Console.ReadLine());

            while (edad3 != 0)
            {

                sumaEdades3 = 0;

                for (int y = 0; y < 20; y++)
                {
                    Console.Write("Ingrese la edad:");
                    edad3 = int.Parse(Console.ReadLine());

                    sumaEdades3 += edad3;

                }

                promedioEdades3 = (double)sumaEdades3 / 20;
                Console.WriteLine($"El promedio de edades es: {promedioEdades3}");


                Console.Write("Ingrese 1 para comenzar a procesar o 0 para terminar:");
                edad3 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-------------------------------------------");

            // Ejemplo 4: Calcular y mostrar el promedio de edades de varios equipos de futbol.
            // cada equipo tiene varios jugadores. corta carga de equipos con numero negativo

            // while con while
            double promedioEdades4;
            int edad4;
            int sumaEdades4;
            int cantidadEdades4;

            int numeroEquipo = 1;

            Console.Write("Ingrese la edad (negativo para terminar equipos): ");
            edad4 = int.Parse(Console.ReadLine());

            while (edad4 >= 0)
            {
                sumaEdades4 = 0;
                cantidadEdades4 = 0;

                while (edad4 > 0)
                {
                    sumaEdades4 += edad4;
                    cantidadEdades4++;

                    Console.Write("Ingrese la edad (0 para cerrar equipo): ");
                    edad4 = int.Parse(Console.ReadLine());
                }

                if (cantidadEdades4 > 0)
                {
                    promedioEdades4 = (double)sumaEdades4 / cantidadEdades4;
                    Console.WriteLine($"El promedio de edades del equipo {numeroEquipo} es: {promedioEdades4}");

                }
                else
                {
                    Console.WriteLine("El equipo no tuvo jugadores");
                }

                numeroEquipo++;

                Console.Write("Ingrese la edad (negativo para terminar equipos): ");
                edad4 = int.Parse(Console.ReadLine());

            }



        }
    }

}