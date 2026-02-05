using System;

namespace U04_EJ05
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            5.  Hacer un programa que solicite el ingreso de las notas del primer parcial y del
            segundo parcial de una alumna de programación. El programa deberá analizar
            las notas y emitir la situación de la alumna según la siguiente escala:

            a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
            b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
            aprueba con 6 o más), emitir “rinde examen final”.
            c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
            recuperar”.

            El programa debe emitir solo un cartel, el que corresponda.
            
             */

            // Declaracion variables
            int notaParcial1;
            int notaParcial2;

            const int NOTA_PROMOCION = 8;
            const int NOTA_APROBACION = 6;

            // Pedir datos
            Console.Write("Ingrese la nota 1: ");
            notaParcial1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            notaParcial2 = int.Parse(Console.ReadLine());

            // Calcular y mostrar
            if (notaParcial1 >= NOTA_PROMOCION && notaParcial2 >= NOTA_PROMOCION)
            {
                Console.WriteLine("Aprobacion directa");
            }
            else if (notaParcial1 >= NOTA_APROBACION && notaParcial2 >= NOTA_APROBACION)
            {
                Console.WriteLine("Rinde examen final");
            }
            else
            {
                Console.WriteLine("Debe recuperar");
            }

            Console.ReadKey();
        }
    }

}