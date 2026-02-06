using System;

namespace U04_EJ08
{


    class Program
    {
        static void Main(string[] args)
        {
            /* 
            8.  El negocio de desinfectante antes mencionado vende además detergente
            suelto, y los precios se aplican según la siguiente escala:

            a. 25 ARS por litro los primeros 50 litros.
            b. 20 ARS por litro si la venta es de 51 a 200 litros.
            c. 15 ARS por litro si la venta es de 201 a 500 litros.
            d. 10 ARS por litro si la venta es de más de 500 litros.

            Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.

            Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
            (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
            y emita por pantalla el monto final a abonar por el cliente.
            
             */

            // DEclaracion variables
            int cantidadLitros;
            int tipoPago;

            decimal montoFinal;

            const decimal PRECIO_LITRO1 = 25m;
            const decimal PRECIO_LITRO2 = 20m;
            const decimal PRECIO_LITRO3 = 15m;
            const decimal PRECIO_LITRO4 = 10m;

            const int LIMITE_LITRO1 = 50;
            const int LIMITE_LITRO2 = 200;
            const int LIMITE_LITRO3 = 500;

            const decimal PORCENTAJE_ADICIONAL = 0.10m;


            // Pedir datos
            Console.Write("Ingrese la cantidad de litros vendidos: ");
            cantidadLitros = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tipo de pago (1. efectivo, 0. otro medio pago)");
            tipoPago = int.Parse(Console.ReadLine());

            // Calcular
            if (cantidadLitros > LIMITE_LITRO3)
            {
                montoFinal = cantidadLitros * PRECIO_LITRO4;
            }
            else if (cantidadLitros > LIMITE_LITRO2)
            {
                montoFinal = cantidadLitros * PRECIO_LITRO3;
            }
            else if (cantidadLitros > LIMITE_LITRO1)
            {
                montoFinal = cantidadLitros * PRECIO_LITRO2;
            }
            else
            {
                montoFinal = cantidadLitros * PRECIO_LITRO1;
            }

            if (tipoPago == 1)
            {
                montoFinal = montoFinal + (montoFinal * PORCENTAJE_ADICIONAL);
            }

            // Mostrar 
            Console.WriteLine($"El monto final es: $ {montoFinal}");

            Console.ReadKey();
        }
    }

}