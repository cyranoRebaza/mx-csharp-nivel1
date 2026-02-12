using System;

namespace U05_EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            10. Hacer un programa que solicite 20 números y luego emitir por pantalla el
            máximo de los números pares y el mínimo de los números impares.
            
             */

            // Declaracion variables
            int numero;
            int maximoPar = 0;
            int minimoImpar = 0;

            bool banderaPar = false;
            bool banderaImpar = false;

            // Pedir datos
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    // pares
                    if (banderaPar == false)
                    {
                        maximoPar = numero;
                        banderaPar = true;
                    }
                    else
                    {
                        if (numero > maximoPar)
                        {
                            maximoPar = numero;
                        }
                    }

                }
                else
                {
                    // impares
                    if (banderaImpar == false)
                    {
                        minimoImpar = numero;
                        banderaImpar = true;
                    }
                    else
                    {
                        if (numero < minimoImpar)
                        {
                            minimoImpar = numero;
                        }
                    }

                }


            }

            // Mostrar resultados
            if (banderaPar)
            {
                Console.WriteLine($"El maximo par es: {maximoPar} ");

            }
            else
            {
                Console.WriteLine("No se ingresaron numeros pares");
            }

            if (banderaImpar)
            {
                Console.WriteLine($"El minimo impar es:  {minimoImpar}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros impares");
            }

            Console.ReadKey();
        }
    }

}