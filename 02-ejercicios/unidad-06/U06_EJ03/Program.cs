
using System;

namespace U06_EJ03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            3. Hacer un programa para ingresar los valores de los pesos de distintas
            encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
            pueden transportar hasta 200 kilos en total.

            Por ejemplo:
            10, 20, 140,  70, 100,  40, 10, 50, 80,  90, 30, 40,  50,    -10.
            Camión 1.    Camión 2  Camión 3          Camión 4    Camión 5
            Se pide determinar e informar:

            a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
            Camión 2: 170kg, etc.).

            b. El número de camión que transporta mayor cantidad de encomiendas
            (en el ejemplo anterior sería el camión 3 con 4 encomiendas).

            c. La cantidad de camiones que se terminaron cargando.
            
             */

            // Declaracion variables
            int pesoEncomienda;
            int pesoCamion;

            // Variables punto a)
            int numeroCamion = 0;

            // Variables punto b)
            int b_numeroCamion = 0;
            int mayorCantidadEncomiendas = 0;
            int cantidadEncomiendas;
            int b_mayorNumeroCamion = 0;

            // Variables punto c)
            int totalCamiones = 0;



            do
            {
                Console.Write("Ingrese el peso de la encomienda: ");
                pesoEncomienda = int.Parse(Console.ReadLine());

                if (pesoEncomienda > 200)
                {
                    Console.WriteLine("Error. El peso debe ser menor o igual a 200kg");
                }
            } while (pesoEncomienda > 200);


            while (pesoEncomienda > 0)
            {
                pesoCamion = 0;

                // Inicializacion punto a)
                numeroCamion++;

                // Inicializacion punto b)
                cantidadEncomiendas = 0;
                b_numeroCamion++;

                // Inicializacion punto c)
                totalCamiones++;

                while (pesoCamion + pesoEncomienda <= 200 && pesoEncomienda > 0)
                {
                    pesoCamion += pesoEncomienda;

                    // Punto b)
                    cantidadEncomiendas++;

                    Console.Write("Ingrese el peso de la encomienda: ");
                    pesoEncomienda = int.Parse(Console.ReadLine());
                }

                // punto a)
                Console.WriteLine($"a) numero camion: #  {numeroCamion}");
                Console.WriteLine($"a) peso total encomienda: {pesoCamion}");

                // Punto b)
                if (cantidadEncomiendas > mayorCantidadEncomiendas)
                {
                    mayorCantidadEncomiendas = cantidadEncomiendas;
                    b_mayorNumeroCamion = b_numeroCamion;

                }
            }

            // punto b)
            Console.WriteLine($"b) El camion con mayor cantidad de encomiendas es: camion # {b_mayorNumeroCamion}");

            // Punto c)
            Console.WriteLine($"c) El total de camiones que se cargaron son: {totalCamiones}");



        }
    }

}