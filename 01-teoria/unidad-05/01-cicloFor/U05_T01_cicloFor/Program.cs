using System;
using System.ComponentModel;

namespace U05_T01_cicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            CICLO FOR

            SINTAXIS:
                for(inicializacion; condicion; incremento){
                    // codigo
                }
            
             */
            Console.WriteLine("--- EJEMPLO 1 ---");

            // EJEMPLO 1: mostrar 5 veces hola mundo       


            // metodo 1: 
            Console.WriteLine("HOla mundo");
            Console.WriteLine("HOla mundo");
            Console.WriteLine("HOla mundo");
            Console.WriteLine("HOla mundo");
            Console.WriteLine("HOla mundo");

            Console.WriteLine("-----------------------");

            // Metodo 2: estructura standar de ciclo for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("HOla mundo");
            }

            Console.WriteLine("--- EJEMPLO 2 ---");

            // EJEMPLO 2: Cargar 5 numeros
            for (int i = 0; i < 5; i++)
            {
                int numero;

                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("--- EJEMPLO 3 ---");

            // EJEMPLO 3: Calcular el promdeio de 5 notas
            int nota;
            double promedioNotas;
            int sumaNotas = 0;
            int cantidadNotas = 0;

            for (int i = 0; i < 5; i++)
            {
                // Cargo las notas
                Console.Write($"Ingrese nota {i + 1}: ");
                nota = int.Parse(Console.ReadLine());

                // acumulando y contando las notas
                sumaNotas += nota;
                cantidadNotas++;
            }

            // calculo el promedio
            promedioNotas = (double)sumaNotas / cantidadNotas;

            // mostrar el promedio de notas
            Console.WriteLine($"El promedio de notas es: {promedioNotas}");
        }
    }

}