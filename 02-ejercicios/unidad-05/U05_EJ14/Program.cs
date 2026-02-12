using System;

namespace U05_EJ14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            14. Hacer un programa que solicite la edad de un grupo de personas. El programa
            deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
            mostrar por pantalla cuántas personas mayores se registraron.
            
             */

            // Declaracion variables
            int edad;
            const int EDAD_LIMITE = 18;
            int cantidadMayorEdad = 0;

            // Pedir datos
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());

            while (edad >= EDAD_LIMITE)
            {
                cantidadMayorEdad++;

                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
            }

            // Mostrar resultado
            Console.WriteLine($"La cantidad de personas mayores es: {cantidadMayorEdad}");

            Console.ReadKey();

        }
    }

}