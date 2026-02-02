using System;

namespace U03_EJ06
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            6. Una casa de video juegos otorga un descuento dependiendo del importe de la
            compra realizada según los siguientes valores:

            • Si el importe es menor a ARS 1000, no hay descuento.
            • Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un
             descuento del 10%.
            • Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            Hacer un programa para ingresar un importe de venta y luego muestre por
            pantalla el importe final con el descuento que corresponda.
            
            */

            // Declaracion variables
            decimal importeVenta;
            decimal importeFinal;

            const decimal PORCENTAJE_DESCUENTO1 = 0.10m;
            const decimal PORCENTAJE_DESCUENTO2 = 0.18m;

            const decimal limiteImporte1 = 1000m;
            const decimal limiteImporte2 = 5000m;

            decimal descuento1;
            decimal descuento2;


            // Pedir datos
            Console.Write("Ingrese el importe de venta: ");
            importeVenta = decimal.Parse(Console.ReadLine());

            // Calcular            
            if (importeVenta > limiteImporte2)
            {
                descuento2 = importeVenta * PORCENTAJE_DESCUENTO2;
                importeFinal = importeVenta - descuento2;
            }
            else
            {
                if (importeVenta > limiteImporte1)
                {
                    descuento1 = importeVenta * PORCENTAJE_DESCUENTO1;
                    importeFinal = importeVenta - descuento1;
                }
                else
                {
                    importeFinal = importeVenta;
                }
            }

            // Mostrar
            Console.WriteLine($"El importe final es: $ {importeFinal:0.00}");


        }
    }

}