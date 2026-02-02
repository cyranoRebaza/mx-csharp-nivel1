using System;

namespace U03_EJ12
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            12. Hacer un programa para ingresar un valor que estará expresado en minutos. Si
            los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
            minutos. Mostrar el resultado en pantalla aclarando si se muestran minutos u
            horas.
            
             */

            // Declaracion variables
            int minutos;
            int horas;

            // Pedir datos
            Console.Write("Ingrese los minutos: ");
            minutos = int.Parse(Console.ReadLine());

            // Calcular
            if (minutos > 60)
            {
                horas = minutos / 60;
                minutos = minutos % 60;

                Console.WriteLine($"horas: {horas} hs");
                Console.WriteLine($"minutos: {minutos} min");
            }
            else
            {
                Console.WriteLine($"minutos: {minutos} min");

            }

            Console.ReadKey();


        }
    }

}