using System;

namespace U04_EJ09
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            9.  Una importante marca de computadoras permite elegir cierta configuración del
            equipo a comprar. Para ello existe la siguiente escala de precios:

                 i5 (1)      i7 (2)      i9 (3)

            8 RAM (1) USD 800 USD 900 USD 1200
            16 RAM (2) USD 900 USD 1000 USD 1400
            32 RAM (3) USD 1000 USD 1400 USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de
            información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
            adicional de USD 300.

            Hacer un programa que solicite la opción de procesador, la opción de memoria
            RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender)
            y calcule y emita por pantalla el monto de la máquina seleccionada.

             */

            // Declaracion variables
            int procesador;
            int memoriaRam;
            int discoRigido;

            const decimal COSTO_ADICIONAL = 300m;

            decimal precio = 0;

            // Pedir datos
            Console.WriteLine("--- OPCIONES DE PROCESADOR ---");
            Console.WriteLine("1. i5");
            Console.WriteLine("2. i7");
            Console.WriteLine("3. i9");

            Console.Write("Ingrese el tipo de procesador: ");
            procesador = int.Parse(Console.ReadLine());

            Console.WriteLine("--- OPCIONES DE MEMORIA RAM ---");
            Console.WriteLine("1. 8 GB");
            Console.WriteLine("2. 16 GB");
            Console.WriteLine("3. 32 GB");

            Console.Write("Ingrese el tipo de memoria ram: ");
            memoriaRam = int.Parse(Console.ReadLine());

            Console.WriteLine("--- DISCO RIGIDO ---");
            Console.WriteLine("0. no extender disco");
            Console.WriteLine("1. extender disco");

            Console.Write("Ingrese si desea extender el disco: ");
            discoRigido = int.Parse(Console.ReadLine());

            // Calcular
            switch (procesador)
            {
                // procesador i5
                case 1:

                    // memoria ram 
                    switch (memoriaRam)
                    {
                        case 1:
                            precio = 800;
                            break;
                        case 2:
                            precio = 900;
                            break;
                        case 3:
                            precio = 1000;
                            break;
                    }
                    break;

                // procesador i7
                case 2:

                    // memoria ram 
                    switch (memoriaRam)
                    {
                        case 1:
                            precio = 900;
                            break;
                        case 2:
                            precio = 1000;
                            break;
                        case 3:
                            precio = 1400;
                            break;
                    }
                    break;

                // procesador i9
                case 3:

                    // memoria ram 
                    switch (memoriaRam)
                    {
                        case 1:
                            precio = 1200;
                            break;
                        case 2:
                            precio = 1400;
                            break;
                        case 3:
                            precio = 2000;
                            break;
                    }
                    break;
            }

            // costo adicional
            if (discoRigido == 1)
            {
                precio += COSTO_ADICIONAL;
            }

            // Mostrar
            Console.WriteLine($"El precio de las pc con las caracteristicas elegidas es: $ {precio}");

            Console.ReadKey();

        }
    }

}