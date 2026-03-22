using System;

namespace U07_T03_vectoresBool
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJEMPLOS CON VECTORES BOOL

            // EJEMPLO 1:
            // Registrar las asistencias por dia de un alumno luego calcular cuantas 
            // cuantas faltas tuvo
            // porcentaje de asistencias

            int valor;
            int contadorInasistencias = 0;
            int contadorAsistencias = 0;
            double porcentajeAsistencia = 0;

            bool[] asistenciaDiaria = new bool[31];


            // cargar vector        
            for (int i = 0; i < asistenciaDiaria.Length; i++)
            {

                Console.Write($"dia {i + 1} - Ingrese: 1-presente, 0-ausente");
                valor = int.Parse(Console.ReadLine());

                if (valor == 1)
                {
                    asistenciaDiaria[i] = true;
                }
                else
                {
                    asistenciaDiaria[i] = false;
                }

            }

            // contar inasistencias
            for (int i = 0; i < asistenciaDiaria.Length; i++)
            {
                if (!asistenciaDiaria[i])
                {
                    contadorInasistencias++;
                }
            }

            // contar asistencias
            for (int i = 0; i < asistenciaDiaria.Length; i++)
            {
                if (asistenciaDiaria[i])
                {
                    contadorAsistencias++;
                }
            }

            // Calcular porcentaje de asistencias
            porcentajeAsistencia = (double)contadorAsistencias * 100 / asistenciaDiaria.Length;


            // mostrar inasistencia
            Console.WriteLine("");
            Console.WriteLine($"Dias Inasistencia: ");

            for (int i = 0; i < asistenciaDiaria.Length; i++)
            {
                if (!asistenciaDiaria[i])
                {
                    Console.WriteLine($"Falto  el dia {i + 1}");
                }
            }

            Console.WriteLine($"total de inasistencia: {contadorInasistencias}");

            // mostrar el porcentaje asistencia
            Console.WriteLine($"Porcentaje de asistencia es: {porcentajeAsistencia}");
        }
    }
}
