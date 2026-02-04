using System;

namespace U04_T02_switch
{

    class Program
    {
        static void Main(string[] args)
        {
            // switch
            // en vez de una condicion logica, tiene es una variables a evaluar
            // Evalua secuencialmente cuando encuentra una coincidencia ejecuta y termina

            char letra = 'A';

            switch (letra)
            {
                case 'M':
                    // Codigo
                    break;
                case 'H':
                    // codigo
                    break;
                default:
                    // no coincide con ninguna
                    break;
            }

        }
    }

}