using System;
using System.Reflection.Metadata;

namespace U06_EJ01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. Se dispone de una lista de 10 grupos de números enteros separados entre ellos
            por ceros. Se pide determinar e informar:

            a. El número de grupo con mayor porcentaje de números impares
            positivos respecto al total de números que forman el grupo.

            b. Para cada grupo, el último número primo y en qué orden apareció en
            ese grupo. Si en un grupo no hubiera números primos, informarlo con
            un cartel aclaratorio.

            c. Informar cuántos grupos están formados por todos números ordenados
            de mayor a menor.
            
             */

            // Declaracion variables
            int numero;

            // Variables punto a)
            int cantidadImparesPositivos;
            int cantidadTotal;
            double porcentajeImparesPositivos = 0;
            double mayorPorcentajeImparesPositivos = 0;
            int GrupoMayorPorcentajeImparesPositivos = 0;

            // Variables punto b)
            int numeroPrimo;
            int posicionNumero;
            int posicionPrimo = 0;

            int cantidadDivisores;

            // Variables punto c)
            int cantidadGruposOrdenados = 0;
            int contadorNumeros;
            int numeroMayor = 0;

            // Estructura principal externa
            for (int i = 0; i < 10; i++)
            {

                // Inicializacion punto a)
                cantidadImparesPositivos = 0;
                cantidadTotal = 0;

                // Inicializacion punto b)
                posicionNumero = 0;
                numeroPrimo = 0;

                // Inicializacion punto c)
                contadorNumeros = 0;
                bool estaOrdenado = true;



                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                // Estructura principal interna
                while (numero != 0)
                {
                    // punto a)
                    cantidadTotal++;

                    if (numero > 0 && numero % 2 != 0)
                    {
                        cantidadImparesPositivos++;
                    }

                    // punto b)
                    posicionNumero++;
                    bool esPrimo = true;

                    if (numero <= 1)
                    {
                        esPrimo = false;
                    }
                    else
                    {

                        for (int divisores = 2; divisores < numero; divisores++)
                        {
                            if (numero % divisores == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }

                        if (esPrimo)
                        {
                            numeroPrimo = numero;
                            posicionPrimo = posicionNumero;
                        }

                    }

                    // punto c)                  
                    contadorNumeros++;

                    if (contadorNumeros == 1)
                    {
                        numeroMayor = numero;
                    }
                    else if (numero > numeroMayor)
                    {
                        estaOrdenado = false;
                    }

                    numeroMayor = numero;






                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }

                // punto a)
                porcentajeImparesPositivos = (double)cantidadImparesPositivos * 100 / cantidadTotal;

                if (porcentajeImparesPositivos > mayorPorcentajeImparesPositivos)
                {
                    mayorPorcentajeImparesPositivos = porcentajeImparesPositivos;
                    GrupoMayorPorcentajeImparesPositivos = i + 1;
                }

                // Punto b)
                if (numeroPrimo != 0)
                {
                    Console.WriteLine($"b) El ultimo numero primo es: {numeroPrimo} en la posicion {posicionPrimo}");
                }
                else
                {
                    Console.WriteLine("b) No hay numeros primos");
                }

                // Punto c)
                if (estaOrdenado)
                {
                    cantidadGruposOrdenados++;
                }


            }

            // punto a)
            Console.WriteLine($"a) El numero de grupo con mayor porcentaje de impares positivos es: {GrupoMayorPorcentajeImparesPositivos}");

            // punto c)
            Console.WriteLine($"c) La cantidad de grupos ordenados es: {cantidadGruposOrdenados}");

            Console.ReadKey();
        }
    }

}