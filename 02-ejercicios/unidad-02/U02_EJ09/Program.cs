using System;

namespace U02_EJ09
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            9. Una universidad desea conocer los porcentajes de mujeres y hombres en las carreras de ciencias exactas. 
            Se solicita un programa para cargar la cantidad de mujeres y la cantidad de hombres y que el mismo calcule 
            y emita por pantalla los porcentajes correspondientes 
            
             */

            // Declaracion variabbles
            int cantidadHombres;
            int cantidadMujeres;
            int cantidadAlumnos;

            double porcentajeHombres;
            double porcentajeMujeres;

            // Pedir los datos
            Console.Write("Ingrese la cantidad de hombres: ");
            cantidadHombres = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de mujeres: ");
            cantidadMujeres = int.Parse(Console.ReadLine());

            // Calcular
            cantidadAlumnos = cantidadHombres + cantidadMujeres;
            porcentajeHombres = (double)cantidadHombres * 100.0 / cantidadAlumnos;
            porcentajeMujeres = (double)cantidadMujeres * 100.0 / cantidadAlumnos;

            // Mostrar
            Console.WriteLine($"El porcentaje de hombres es: {porcentajeHombres:0.00} %");
            Console.WriteLine($"El porcentaje de mujeres es: {porcentajeMujeres:0.00} %");


        }
    }

}