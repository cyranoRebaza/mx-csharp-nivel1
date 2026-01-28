using System;

namespace U02_EJ07
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            7. Hacer un programa para ingresar por teclado los metros cuadrados totales de un predio y los 
            metros cuadrados cubiertos; luego calcular y mostrar por pantalla el porcentaje de metros 
            cuadrados cubiertos y el porcentaje de metros cuadrados descubiertos. 

            ---------------------------------------------------------------------------
            nota: 
            metodo ToString("0.00") 
            - redondear a dos decimales de los datos de salida
            - redondea la salida sin modificar el valor
            
            :0.00
            - : Lo que viene despues es el formato
            - 0.00 es el formato numeros
             */

            // Declracion variables
            double metrosTotales;
            double metrosCubiertos;
            double metrosDescubiertos;

            double porcentajeMetrosCubiertos;
            double porcentajeMetrosDescubiertos;

            // Pedir datos
            Console.Write("Ingrese los metros cuadrados totales: ");
            metrosTotales = double.Parse(Console.ReadLine());

            Console.Write("Ingrese los metros cuadrados cubiertos: ");
            metrosCubiertos = double.Parse(Console.ReadLine());

            // Calcular
            metrosDescubiertos = metrosTotales - metrosCubiertos;

            porcentajeMetrosCubiertos = metrosCubiertos * 100.0 / metrosTotales;
            porcentajeMetrosDescubiertos = metrosDescubiertos * 100.0 / metrosTotales;

            // Mostrar
            Console.WriteLine($"Porcentaje metros cubiertos: {porcentajeMetrosCubiertos.ToString("0.00")}");
            Console.WriteLine($"Porcentaje metros descubiertos: {porcentajeMetrosDescubiertos:0.00}");

            Console.ReadKey();

        }
    }

}