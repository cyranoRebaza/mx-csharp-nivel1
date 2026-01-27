using System;

namespace U02_EJ03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            3. Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento 
            de una persona y luego calcule y emita por pantalla su edad.

            Nota: no hay que tener en cuenta si la persona cumplió años o no, simplemente calcular.

             */

            // Declaracion variables
            int anioActual;
            int anioNacimiento;
            int edad;

            // Pedir datos
            Console.Write("Ingrese el anio actual: ");
            anioActual = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el anio de nacimiento: ");
            anioNacimiento = int.Parse(Console.ReadLine());

            // Calcular
            edad = anioActual - anioNacimiento;

            // Mostrar
            Console.WriteLine($"La edad es: {edad}");

            Console.ReadKey();
        }
    }

}