using System;
namespace U04_T01_operadoresLogicos
{

    class Program
    {
        static void Main(string[] args)
        {
            // AND (&&) : ambos verdadero

            //    true   &&  true  = true
            //    true   &&  false = false
            //    false  &&  true  = false
            //    false  &&  false = false

            int edad = 20;
            char inicial = 'J';

            if (edad > 20 && inicial == 'H')
            {
                Console.WriteLine("Tedras un descuento de 20 %");
            }


            // OR (||): con un solo verdadero es sufiente los demas es falso 

            //    true   &&  true  = true
            //    true   &&  false = true
            //    false  &&  true  = true
            //    false  &&  false = false

            if (edad > 20 && (inicial == 'H' || inicial == 'J'))
            {
                Console.WriteLine("Tedras un descuento de 20 %");
            }

            // NOT (!) : niego una condicion
            // dar un descuento a todos que sea mayores a 20, pero que no tengan iniciales a "I" o "J         

            if (edad > 20 && !(inicial == 'H' || inicial == 'J'))
            {
                Console.WriteLine("Tedras un descuento de 20 %");
            }
        }
    }

}