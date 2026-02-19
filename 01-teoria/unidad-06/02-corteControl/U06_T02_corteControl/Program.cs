using System;

namespace U06_T02_corteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     
            
            - Corte control: estrategia para manejear lotes de datos AGRUPADOS
                           - cambia de grupo automaticamente

            - DATO Y REGISTRO
                - DATO: es un solo valor
                - REGISTRO: varios datos 



                 while (true)
                 {
                     while (true)
                     {

                     }
                 } 

             */

            // Ejemplo: Cargar de cada jugador legajo, edad, sueldo agrupados
            // por codigo de equipo, donde el lote corta con sueldo negativo
            // pero el sublote va cambiar cuando cambie el codigo de equipo

            // Declarar variables
            int legajo;
            int edad;
            int codigoEquipo;
            int codigoEquipoActual;
            decimal sueldo;

            // Pedir datos
            Console.Write("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el codigo de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLine());


            while (sueldo > 0)
            {
                codigoEquipoActual = codigoEquipo;

                while (codigoEquipo == codigoEquipoActual)
                {

                    // Aca procesamos

                    Console.Write("Ingrese el legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el sueldo: ");
                    sueldo = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el codigo de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLine());

                    // Aca se puede mostrar resultados de cada registro

                }

                // Aca se puede mostrar resultados cada equipo

            }

            // Aca tambien se puede mostrar resultados de todos los equipos




        }
    }

}