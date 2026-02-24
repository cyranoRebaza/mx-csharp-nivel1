using System;


namespace U06_EJ04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            4. Una compañía de turismo aventura registró los paquetes vendidos durante la
            última temporada vacacional. Para cada venta se ingresó:

                • Número de paquete (4 dígitos no correlativos).
                • Cantidad de personas incluidas.
                • Precio por persona.
                • Horas totales de actividades.
                • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.
            “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,
            Parapente).

            El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con
            número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura
            no se haya vendido.

            A partir de dichos datos, se solicita informar:

            a. La cantidad de paquetes vendidos de cada tipo de aventura..
            b. La cantidad total de personas que disfrutaron de las aventuras durante la
            temporada.
            c. El total recaudado por cada venta.
            d. La venta con mayor importe de cada tipo de aventura.
            e. El paquete con menos horas incurridas y en qué tipo de actividad fue
            
             */

            // Declaracion variables
            int numeroPaquete;
            int cantidadPersonas;
            decimal precioPorPersona;
            int horasTotalesActividad;
            char tipoAventura;

            char tipoAventuraActual;

            // Variables punto a)
            int cantidadPaquetesAventura;

            // variables punto b)
            int cantidadTotalPersonas = 0;

            // variables punto c)
            decimal totalRecaudadoVenta = 0;

            // variables punto d)
            decimal importeVenta;
            decimal mayorImporteVenta;

            // variables punto e)
            int menorHorasIncurridas = 0;
            char menorTipoActividad = ' ';
            int menorNumeroPaquete = 0;

            // Pedir los datos
            Console.Write("Ingrese el numero de paquete: ");
            numeroPaquete = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese la cantidad de personas incluidas: ");
            cantidadPersonas = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el precio por persona: ");
            precioPorPersona = decimal.Parse(Console.ReadLine()!);

            Console.Write("Ingrese las horas totales de actividad: ");
            horasTotalesActividad = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el tipo de aventura: ");
            tipoAventura = char.Parse(Console.ReadLine()!);


            // inicializo punto e)
            menorHorasIncurridas = horasTotalesActividad;
            menorTipoActividad = tipoAventura;




            while (numeroPaquete != 0)
            {

                // Inicializacion Punto a)
                cantidadPaquetesAventura = 0;

                // Inicializacion Punto d)
                mayorImporteVenta = 0;


                tipoAventuraActual = tipoAventura; // cc
                while (tipoAventura == tipoAventuraActual)
                {

                    // punto a)
                    cantidadPaquetesAventura++;

                    // punto b)
                    cantidadTotalPersonas += cantidadPersonas;

                    // punto c)
                    totalRecaudadoVenta = cantidadPersonas * precioPorPersona;
                    Console.WriteLine($"c) El total recaudado por cada venta: $ {totalRecaudadoVenta}");

                    // punto d)
                    importeVenta = cantidadPersonas * precioPorPersona;
                    if (importeVenta > mayorImporteVenta)
                    {
                        mayorImporteVenta = importeVenta;
                    }

                    // punto e)
                    if (horasTotalesActividad < menorHorasIncurridas)
                    {
                        menorHorasIncurridas = horasTotalesActividad;
                        menorTipoActividad = tipoAventura;
                        menorNumeroPaquete = numeroPaquete;
                    }



                    // Pedir los datos
                    Console.Write("Ingrese el numero de paquete: ");
                    numeroPaquete = int.Parse(Console.ReadLine()!);

                    Console.Write("Ingrese la cantidad de personas incluidas: ");
                    cantidadPersonas = int.Parse(Console.ReadLine()!);

                    Console.Write("Ingrese el precio por persona: ");
                    precioPorPersona = decimal.Parse(Console.ReadLine()!);

                    Console.Write("Ingrese las horas totales de actividad: ");
                    horasTotalesActividad = int.Parse(Console.ReadLine()!);

                    Console.Write("Ingrese el tipo de aventura: ");
                    tipoAventura = char.Parse(Console.ReadLine()!);
                }

                // punto a)
                Console.WriteLine($"a) cantidad de paquetes de cada tipo aventura es: {cantidadPaquetesAventura}");



                // punto d)
                Console.WriteLine($"d) La venta con mayor importe de cada tipo de aventura es: $ {mayorImporteVenta}");

            }

            // punto b)
            Console.WriteLine($"b) La cantidad total de personas disfrutaron la temporada es {cantidadTotalPersonas}");

            // punto e)
            Console.WriteLine($"e) el menor numero de paquete es: {menorNumeroPaquete} y tipo actividad es {menorTipoActividad} ");
        }
    }

}