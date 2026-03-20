using System;

namespace U07_T01_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            VECTOR

            DECLARACION VECTOR:
                - int[] numeros; // declaro referencia, no tiene tamaño, aun no existe en memoria
                - new int[5]; // CONSTRUCTOR de objetos en memoria

            Inicializar con determinado tamaño
                int[] numeros = new int[5];

            Inicializar con valores
                int[] numeros = {10,20,30,40,50};

            ---------------------------------------------
            int[] vector = new int[5];

            -todas las posiciones vienen con valores por defecto
                numericos --> 0 
                bool --> false
                string --> null

            - para inicializar con otro valor distinto
                recorro con un for

                for (int i = 0; i < numeros.Length; i++)
                {
                Console.WriteLine(numeros[i]);
                }
            

            

             */

            // Ejemplo 1:
            int[] vector; // declarar
            vector = new int[5]; // inicializar


            // Ejemplo 2: Declaracion e inicializacion          
            int[] vector2 = new int[5];

            // Ejemplo 3: comparar asignacion de variables simple con vector
            int dia;
            int[] dias = new int[12];

            dia = 1; // representa a lunes

            dias[0] = 1;
            dias[1] = 2;
            dias[2] = 3;
            dias[3] = 4;
            dias[4] = 5;
            dias[5] = 6;
            dias[6] = 7;

            // Ejemplo 4: ingresar 5 numeros y mostrarlos
            int[] numeros = new int[5];

            // cargar datos
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Mostrar datos
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }





        }
    }
}
