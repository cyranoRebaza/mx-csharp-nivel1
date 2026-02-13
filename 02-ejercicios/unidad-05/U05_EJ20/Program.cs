using System;

namespace U05_EJ20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            20. Realizar el nuevamente el ejercicio 19 pero ahora debe devolver además la
            posición en la que fue encontrado cada uno de los mínimos.

             */
            // Declaracion variables
            int numero;

            int primerMenor = 0;
            int segundoMenor = 0;

            int posicion = 1;
            int posicionPrimerMenor = 0;
            int posicionSegundoMenor = 0;

            bool hayPrimerMenor = false;
            bool haySegundoMenor = false;


            // Pedir el primer numero
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                // tomamos el primer numero como el primer menor
                if (!hayPrimerMenor)
                {
                    primerMenor = numero;
                    posicionPrimerMenor = posicion;
                    hayPrimerMenor = true;
                }
                else
                {
                    // buscamos el segundo menor
                    if (!haySegundoMenor)
                    {
                        haySegundoMenor = true;

                        // si el numero nuevo es menor que menor - el primero pasa a ser el segundo
                        if (numero < primerMenor)
                        {
                            segundoMenor = primerMenor;
                            primerMenor = numero;

                            posicionSegundoMenor = posicionPrimerMenor;
                            posicionPrimerMenor = posicion;
                        }
                        else
                        {
                            // sino, el nuevo numero es el segundo menor
                            segundoMenor = numero;
                            posicionSegundoMenor = posicion;
                        }
                    }
                    else
                    {
                        // si ya existen ambos numeros menores
                        if (numero < primerMenor)
                        {
                            segundoMenor = primerMenor;
                            primerMenor = numero;

                            posicionSegundoMenor = posicionPrimerMenor;
                            posicionPrimerMenor = posicion;
                        }
                        else
                        {
                            if (numero < segundoMenor)
                            {
                                segundoMenor = numero;
                                posicionSegundoMenor = posicion;
                            }
                        }
                    }
                }

                posicion++;

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

            } //fin while

            // Mostrar resultados
            if (hayPrimerMenor && haySegundoMenor)
            {
                Console.WriteLine($"El primer menor es: {primerMenor} en la posicion {posicionPrimerMenor}");
                Console.WriteLine($"El segundo menor es: {segundoMenor} en la posicion {posicionSegundoMenor}");

            }
            else
            {
                Console.WriteLine("se ingreso un solo numero");
            }

            Console.ReadKey();

        }
    }

}