using System;

namespace U06_EJ05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            5. Una empresa registró las compras realizadas a sus distintos proveedores durante
            todo el año anterior. Para cada compra se registraron los siguientes datos:

                • Número de proveedor (número de cuatro cifras no correlativo).
                • Día (1 a 31).
                • Mes (1 a 12).
                • Tipo de Factura (Responsable inscripto: "A",Consumidor Final: "B", o
                Monotributo: "C").
                • Número de Producto (número no correlativo).
                • Cantidad comprada.
                • Precio unitario del producto.

            Este lote finaliza con un registro con número de proveedor igual a 0.

            Los registros están agrupados por número de proveedor. En el lote anterior no
            Aparecen registros de los proveedores a los que  no se les hayan realizado compras.
            Se pide determinar e informar:

            a. El monto máximo registrado en una sola compra por cada proveedor y el
            número de proveedor al que se le compró.

            b. La inversión total de todo el año discriminada por tipo de factura.

            c. La compra con menor monto registrada durante el mes de Agosto junto al
            número de producto comprado.

            d. La cantidad de compras que se realizaron a cada proveedor.

            e. El número de producto con mayor cantidad comprada en una sola compra y
            en qué proveedor se compró.

             */

            // Declaracion variables
            int numeroProveedor;
            int dia;
            int mes;
            char tipoFactura;
            int numeroProducto;
            int cantidadComprada;
            decimal precioUnitario;

            int numeroProveedorActual;

            // variables punto a)
            decimal montoA;
            decimal montoMaximoProveedor;

            // variables punto b)
            decimal montoB;
            decimal facturaA = 0;
            decimal facturaB = 0;
            decimal facturaC = 0;

            // variables punto c)
            decimal montoC;
            bool hayMontoMenor = false;
            decimal montoMenor = 0;
            int menorNumeroProducto = 0;

            // variables punto d)
            int cantidadCompra;

            // variables punto e)
            int mayorCantidadComprada = 0;
            int maximoNumeroProducto = 0;
            int maximoNumeroProveedor = 0;


            Console.Write("Ingrese el numero de proveedor: ");
            numeroProveedor = int.Parse(Console.ReadLine());

            while (numeroProveedor != 0)
            {
                // Inicializacion punto a)
                montoMaximoProveedor = 0;

                // Inicializacion punto d)
                cantidadCompra = 0;

                numeroProveedorActual = numeroProveedor; // cc
                while (numeroProveedor == numeroProveedorActual)
                {

                    Console.Write("Ingrese el dia: ");
                    dia = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el mes: ");
                    mes = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el tipoFactura: ");
                    tipoFactura = char.Parse(Console.ReadLine());
                    Console.Write("Ingrese el numero de producto: ");
                    numeroProducto = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad comprada: ");
                    cantidadComprada = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el precio unitario: ");
                    precioUnitario = int.Parse(Console.ReadLine());

                    // Punto a)
                    montoA = cantidadComprada * precioUnitario;

                    if (montoA > montoMaximoProveedor)
                    {
                        montoMaximoProveedor = montoA;
                    }

                    // punto b)
                    montoB = cantidadComprada * precioUnitario;

                    switch (tipoFactura)
                    {
                        case 'a':
                        case 'A':
                            facturaA += montoB;
                            break;

                        case 'b':
                        case 'B':
                            facturaB += montoB;
                            break;

                        case 'c':
                        case 'C':
                            facturaC += montoB;
                            break;

                    }

                    // Punto c)
                    montoC = cantidadComprada * precioUnitario;

                    if (mes == 8)
                    {
                        if (!hayMontoMenor)
                        {
                            montoMenor = montoC;
                            menorNumeroProducto = numeroProducto;
                            hayMontoMenor = true;
                        }
                        else
                        {
                            if (montoC < montoMenor)
                            {
                                montoMenor = montoC;
                                menorNumeroProducto = numeroProducto;
                            }
                        }
                    }


                    // Punto d)
                    cantidadCompra++;

                    // Punto e)
                    if (cantidadComprada > mayorCantidadComprada)
                    {
                        mayorCantidadComprada = cantidadComprada;
                        maximoNumeroProducto = numeroProducto;
                        maximoNumeroProveedor = numeroProveedor;
                    }






                    Console.Write("Ingrese el numero de proveedor: ");
                    numeroProveedor = int.Parse(Console.ReadLine());
                } //fin while intero

                // punto a)
                Console.WriteLine($"a) El monto maximo es: {montoMaximoProveedor} del proveedor {numeroProveedorActual}");

                // punto d)
                Console.WriteLine($"d) La cantidad de compras a cada proveedor es: {cantidadCompra}");


            } //fin while externo

            // Punto b)
            Console.WriteLine($"b) La inversion con factura tipo A: $ {facturaA} ");
            Console.WriteLine($"b) La inversion con factura tipo B: $ {facturaB} ");
            Console.WriteLine($"b) La inversion con factura tipo C: $ {facturaC} ");

            // Punto c)
            if (hayMontoMenor)
            {
                Console.WriteLine($"c) La compra con menor monto es: $ {montoMenor} del numero de producto {menorNumeroProducto} ");
            }
            else
            {
                Console.WriteLine($"c) No hubo compras en el mes de agosto. ");
            }


            // Punto e)
            Console.WriteLine($"El numero de producto maximo es: {maximoNumeroProducto} del proveedor {maximoNumeroProveedor}");

        }
    }

}