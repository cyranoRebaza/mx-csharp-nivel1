using System;

namespace U07_T02_vectoresDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPO DE DATOS: float - double - decimal

            // Ejemplo: registrar las temperaturas diaria de un mes de 31 dias
            // luego calcular el promedio del turno matutino

            // Declarar los vectores
            double[] registroMatutino = new double[31];
            double[] registroVespertino = new double[31];
            double[] registroNocturno = new double[31];

            // Cargar datos
            // registro matutino
            int dia;
            double temperatura;
            for (int i = 0; i < registroMatutino.Length; i++)
            {
                Console.Write("Ingrese el dia:");
                dia = int.Parse(Console.ReadLine());

                Console.Write("Ingrese temperatura resgistrada: ");
                temperatura = double.Parse(Console.ReadLine());

                registroMatutino[dia - 1] = temperatura;
            }

            for (int i = 0; i < registroVespertino.Length; i++)
            {
                Console.Write("Ingrese el dia:");
                dia = int.Parse(Console.ReadLine());

                Console.Write("Ingrese temperatura resgistrada: ");
                temperatura = double.Parse(Console.ReadLine());

                registroVespertino[dia - 1] = temperatura;
            }

            for (int i = 0; i < registroNocturno.Length; i++)
            {
                Console.Write("Ingrese el dia:");
                dia = int.Parse(Console.ReadLine());

                Console.Write("Ingrese temperatura resgistrada: ");
                temperatura = double.Parse(Console.ReadLine());

                registroNocturno[dia - 1] = temperatura;
            }

            // leer vectores
            for (int i = 0; i < registroMatutino.Length; i++)
            {
                Console.WriteLine($"dia {i + 1}:  M: {registroMatutino[i]} V: {registroVespertino[i]} N: {registroNocturno[i]} ");

            }

            // promedio matutino
            double acuTemperaturas = 0;
            double promedioMatutino = 0;

            for (int i = 0; i < registroMatutino.Length; i++)
            {
                acuTemperaturas += registroMatutino[i];
            }

            promedioMatutino = acuTemperaturas / registroMatutino.Length;

            Console.WriteLine($"El promedio temperatura matutino es: {promedioMatutino}");

        }
    }
}
