using System;
using System.Reflection;

namespace U02_EJ08
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            8. Una importante cadena de delivery cuenta con una promoción por tiempo limitado en la que otorga 
            un 15% de descuento sobre el total del valor de la compra realizada. Hacer un programa para solicitar 
            el monto total y el mismo calcule y emita por pantalla el total a cobrar con el descuento aplicado.
            
             */

            // Declaracion varibles
            decimal montoTotal;
            decimal totalCobrar;
            decimal descuento;

            const decimal PORCENTAJE_DESCUENTO = 0.15m;

            // Pedir datos
            Console.Write("Ingrese el monto total: ");
            montoTotal = decimal.Parse(Console.ReadLine());

            // Calcular
            descuento = montoTotal * PORCENTAJE_DESCUENTO;
            totalCobrar = montoTotal - descuento;

            // Mostrar
            Console.WriteLine($"El total a cobrar es: $ {totalCobrar:0.00}");
        }
    }

}