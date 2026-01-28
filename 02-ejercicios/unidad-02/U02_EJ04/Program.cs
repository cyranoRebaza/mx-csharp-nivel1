using System;

namespace U02_EJ04
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            4. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la 
            velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que 
            demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            
             */

            // Declaracion variables
            float distancia;
            float velocidadPromedio;
            float tiempo;

            // Pedir datos
            Console.Write("Ingrese la distancia entre las ciudades: ");
            distancia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la velocidad promedio: ");
            velocidadPromedio = int.Parse(Console.ReadLine());

            // Calcular
            tiempo = distancia / velocidadPromedio;

            // Mostrar
            Console.WriteLine($"El tiempo estimado es: {tiempo} horas");

            Console.ReadKey();
        }
    }

}