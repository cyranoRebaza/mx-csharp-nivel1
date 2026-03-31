using System;

namespace U07_T04_cadenaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            DIFERENCIA ENTRE:

                - CADENA DE CARACTERES
                    - es un concepto abastracto
                    - es una secuencia de caracteres

                - VECTOR DE CHAR (vector de caracteres):
                    - es un lugar donde puedo guardar caracteres(implementacion en memoria)
                    - es un vector donde cada posicion guarda un CARACTER
                    - usa caracter nulo barra cero (\0 - fin de cadena) indica que aca termina la cadena
                    - puedo modificar cada elemento

                    - representa la cadena de caracteres en memoria

                - STRING:
                    - es un tipo de dato
                    - conceptualmente es un vector de char
                    - es inmutable(no se puede cambiar un caracter directamente)
                    - tiene funcionalidades como .Length  .ToUpper

            
             */

            //  Ejemplo1: cargar tu nombre caracter por caracter que termina con un punto luego mostrarlo


            // Declarciones
            int tamanio;
            char letra;
            int indice = 0;

            // Pedir la cantidad de caracteres posibles
            Console.Write("Ingrese la cantidad de caracteres: ");
            tamanio = int.Parse(Console.ReadLine()!);

            char[] nombre = new char[tamanio + 1];

            // Cargar letras
            Console.WriteLine("Ingrese su nombre letra por letra. (termina con punto)");
            letra = char.Parse(Console.ReadLine()!);

            while (letra != '.' && indice < tamanio)
            {
                nombre[indice] = letra;
                indice++;

                letra = char.Parse(Console.ReadLine()!);
            }

            nombre[indice] = '\0'; // aqui termina la cadena

            // Mostrar
            Console.Write("hola ");

            indice = 0;
            while (nombre[indice] != '\0')
            {
                Console.Write(nombre[indice]);
                indice++;

            }

            // Ejemplo 2: cargar nombre usando tipo de dato string y mostrarlo
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            string apodo;
            Console.Write("Ingrese su nombre: ");
            apodo = Console.ReadLine()!;
            Console.WriteLine($"Hola {apodo}");

        }
    }
}
