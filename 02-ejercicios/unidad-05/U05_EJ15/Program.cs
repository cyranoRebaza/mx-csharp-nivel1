using System;

namespace U05_EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            15. Hacer un programa que solicite dos números y luego muestre los números
            entre el menor y el mayor de ellos. Acordate, usando While.
            
             */

            // Declaracion variables
            int numero1;
            int numero2;
            int menor;
            int mayor;

            // Pedir datos
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = int.Parse(Console.ReadLine());

            // buscando mayor y menor
            if (numero1 < numero2)
            {
                menor = numero1;
                mayor = numero2;
            }
            else
            {
                menor = numero2;
                mayor = numero1;
            }

            // Mostrar numeros entre menor y el mayor
            menor++;

            while (menor < mayor)
            {
                Console.WriteLine(menor);
                menor++;
            }

            Console.ReadKey();

        }
    }

}