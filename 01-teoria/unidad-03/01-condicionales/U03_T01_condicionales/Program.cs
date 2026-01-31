using System;
namespace U03_T01_condicionales
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            expresion lógica: devuevle true o false
            valor operador valor

            operadores lógicos
            < > <= >= == !=

            n1 > 10
            10 > 5 -> NO, puede generar codigo inalcansable

            sintaxis:            
            
            bloque if(valor OPERADOR valor){
                // entra si la expresion logica es verdadera
            }
             */

            // Ejemplo 1: siempre sera verdadero
            if (10 > 5)
            {
                Console.WriteLine("Entra al if");
            }
            else
            {
                Console.WriteLine("Fin del programa"); // codigo inalcansable
            }

            // Ejemplo 2: siempre sera falso
            if (10 < 5)
            {
                Console.WriteLine("Entra al if"); // codigo inalcansable
            }
            else
            {
                Console.WriteLine("Fin del programa");
            }

            // Ejemplo 3: siempre sera falso
            int edad = 20;
            if (edad > 21)
            {
                Console.WriteLine("Entre a la parte verdadera, porque la condicion es verdadera");
            }
            else
            {
                Console.WriteLine("Entre a la parte falsa, porque la condicion es falsa");
            }

            // Ejemplo 4: if anidado compacto, donde se dara un descuento depende de la edad
            int edad2 = 20;
            if (edad2 > 30)
            {
                Console.WriteLine("Descuento de 30%");
            }
            else if (edad2 > 20)
            {
                Console.WriteLine("Descuento de 20%");
            }
            else if (edad2 == 18)
            {
                Console.WriteLine("Descuento de 18%");
            }
            else
            {
                Console.WriteLine("Descuento del 5% para el resto");
            }

            Console.WriteLine("Fin de programa");


        }
    }

}