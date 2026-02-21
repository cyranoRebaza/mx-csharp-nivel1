using System;

namespace U06_EJ02
{


    class Program
    {
        static void Main(string[] args)
        {
            /* 
            2. Una compañía de electricidad necesita calcular anualmente el consumo que ha
            registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
            Para ello tiene un lote de registros por cada uno de los usuarios con los
            siguientes datos:

                • Zona (numérico entero).
                • Número de cliente (número de cuatro dígitos no correlativos).
                • Cantidad de kilovatios consumidos en el periodo.

            El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
            con zona igual a cero.

            Se pide generar un listado con el siguiente formato:

            Zona: XX
            Cantidad de usuarios de la zona: XX
            Total facturado en la zona: XX

            Zona: XX
            Cantidad de usuarios de la zona: XX
            Total facturado en la zona: XX

            El precio es escalonado según la siguiente escala:
                • $ 0.10 por kv por los primeros 100 kv de consumo.
                • $ 0.12 por kv por el consumo de 101 a 200 kvs.
                • $ 0.15 por kv por el consumo de 201 kvs en adelante.
             */

            // Declaracion variables
            int zona;
            int numeroCliente;
            int kilovatiosConsumidos;
            int zonaActual;

            int cantidadUsuario;
            decimal facturacionParcial = 0;
            decimal totalFacturado;

            Console.Write("Ingrese la zona: ");
            zona = int.Parse(Console.ReadLine());

            // Estructura externa
            while (zona != 0)
            {

                zonaActual = zona; // cc

                cantidadUsuario = 0;
                totalFacturado = 0;

                // Estructuras internas
                while (zona == zonaActual)
                {
                    Console.Write("Ingrese numero cliente: ");
                    numeroCliente = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese los kilovatiosConsumidos: ");
                    kilovatiosConsumidos = int.Parse(Console.ReadLine());

                    cantidadUsuario++;

                    if (kilovatiosConsumidos <= 100)
                    {
                        facturacionParcial = 0.10m * kilovatiosConsumidos;
                    }
                    else if (kilovatiosConsumidos <= 200)
                    {
                        facturacionParcial = (0.10m * 100) + 0.12m * (kilovatiosConsumidos - 100);

                    }
                    else
                    {
                        facturacionParcial = (0.10m * 100) + (0.12m * 100) + (0.15m * (kilovatiosConsumidos - 200));
                    }

                    totalFacturado += facturacionParcial;



                    Console.Write("Ingrese la zona: ");
                    zona = int.Parse(Console.ReadLine());

                } // fin while interno

                // mostrar
                Console.WriteLine($"zona: {zonaActual}");
                Console.WriteLine($"Cantidad de usuarios en la zona: {cantidadUsuario}");
                Console.WriteLine($"Total facturado en la zona: $ {totalFacturado:0.00}");
            }
        }
    }

}