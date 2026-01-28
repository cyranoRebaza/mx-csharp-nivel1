using System;

namespace U02_EJ06
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            6. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y 
            luego calcule y emita por pantalla el promedio final. 
            
             */


            // Declaracion variables
            int nota1;
            int nota2;
            int nota3;
            double promedioNotas;

            int cantidadNotas = 0;
            int sumaNotas = 0;

            // Pedir datos
            Console.Write("Ingrese la nota 1: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 1: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 1: ");
            nota3 = int.Parse(Console.ReadLine());

            // Calcular
            sumaNotas = nota1 + nota2 + nota3;
            cantidadNotas = 3;
            promedioNotas = (double)sumaNotas / cantidadNotas;

            // Mostrar
            Console.WriteLine($"El promedio de notas es: {promedioNotas.ToString("0.00")}");

            Console.ReadKey();

        }
    }

}