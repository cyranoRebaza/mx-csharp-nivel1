using System;
namespace U02_EJ05
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
            5. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 
            5% sobre el total facturado por cada empleado. 
            
            Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita 
            por pantalla el sueldo total a cobrar por el mismo.

            ----------------------------------------------------------------
            nota: en C#, todo literal decimal sin sufijo es un double por defecto
            
             */

            // Declaracion variables
            decimal totalFacturado;
            decimal sueldoTotal;
            decimal comision;

            const decimal SUELDO_FIJO = 15000m;
            const decimal PORCENTAJE_COMISION = 0.05m;

            // Pedir datos
            Console.Write("Ingrese el total facturado: ");
            totalFacturado = decimal.Parse(Console.ReadLine());

            // Calcular
            comision = totalFacturado * PORCENTAJE_COMISION;
            sueldoTotal = SUELDO_FIJO + comision;

            // Mostrar
            Console.WriteLine($"El sueldo total es: $ {sueldoTotal}");

            Console.ReadKey();



        }
    }

}