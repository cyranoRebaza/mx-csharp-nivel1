using System;

namespace U05_EJ19
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            19. Hacer un programa que solicite una lista de números que corta cuando se
            ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.
            
             */

            // Declaracion variables
            int numero;
            int primerMenor = 0;
            int segundoMenor = 0;

            bool hayPrimerMenor = false;
            bool haySegundoMenor = false;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (!hayPrimerMenor)
                {
                    primerMenor = numero;
                    hayPrimerMenor = true;
                }
                else
                {
                    if (!haySegundoMenor)
                    {
                        haySegundoMenor = true;

                        if (numero < primerMenor)
                        {
                            segundoMenor = primerMenor;
                            primerMenor = numero;
                        }
                        else
                        {
                            segundoMenor = numero;
                        }
                    }
                    else
                    {
                        if (numero < primerMenor)
                        {
                            segundoMenor = primerMenor;
                            primerMenor = numero;
                        }
                        else
                        {
                            if (numero < segundoMenor)
                            {
                                segundoMenor = numero;
                            }
                        }
                    }
                }



                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Mostrar resultados
            if (hayPrimerMenor && haySegundoMenor)
            {

                Console.WriteLine($"El primer menor es: {primerMenor}");
                Console.WriteLine($"El segundo menor es: {segundoMenor}");
            }
            else
            {
                Console.WriteLine("se ingreso un solo numero");
            }

            Console.ReadKey();
        }
    }

}