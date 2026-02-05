using System;

namespace U04_EJ04
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            4. Un importante negocio de desinfectante líquido realiza descuentos
            dependiendo de la cantidad de litros vendidos según la siguiente escala:

            a. Si vende menos de 100 litros, no hay descuento.
            b. Si vende entre 101 y 300 litros, el descuento es del 10%.
            c. Si vende entre 301 y 500 litros, el descuento es del 15%.
            d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            Hacer un programa que solicite el ingreso del importe total de la venta y la
            cantidad de litros vendidos y calcule y emita el importe con el descuento
            aplicado.
                        
             */

            // Declaracion variables
            decimal importeVenta;
            decimal importeFinal;
            decimal descuento;

            int cantidadLitros;

            const int LIMITE_LITROS1 = 100;
            const int LIMITE_LITROS2 = 300;
            const int LIMITE_LITROS3 = 500;

            const decimal PORCENTAJE_DESCUENTO1 = 0.10m;
            const decimal PORCENTAJE_DESCUENTO2 = 0.15m;
            const decimal PORCENTAJE_DESCUENTO3 = 0.25m;

            // Pedir datos
            Console.Write("Ingrese importe de venta: ");
            importeVenta = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de litros vendidos: ");
            cantidadLitros = int.Parse(Console.ReadLine());

            // Calcular
            if (cantidadLitros > LIMITE_LITROS3)
            {
                descuento = importeVenta * PORCENTAJE_DESCUENTO3;
                importeFinal = importeVenta - descuento;
            }
            else if (cantidadLitros > LIMITE_LITROS2)
            {
                descuento = importeVenta * PORCENTAJE_DESCUENTO2;
                importeFinal = importeVenta - descuento;
            }
            else if (cantidadLitros > LIMITE_LITROS1)
            {
                descuento = importeVenta * PORCENTAJE_DESCUENTO1;
                importeFinal = importeVenta - descuento;
            }
            else
            {
                importeFinal = importeVenta;
            }

            // Mostrar
            Console.WriteLine($"El importe final es: $ {importeFinal:0.00}");


            Console.ReadKey();


        }
    }

}