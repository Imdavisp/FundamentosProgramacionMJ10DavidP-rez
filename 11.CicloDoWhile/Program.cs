using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Ciclo Dowhile
             int contador = 1;
             int acumulador = 0;

             do
             {
                 acumulador += contador;
                 contador++;
             }while (contador <= 5);

             Console.WriteLine($"La suma de los cinco primeros números enteros es:{acumulador}
 */

            int contador = 1;
            int contador2 = 1;
            int contadorDivisiones = 0;
            do
            {
                do
                {
                    if (contador % contador2 == 0)
                    {
                        contadorDivisiones++;
                    }
                } while (contador2 <= contador);
                contador2 = 1;
                //Console.WriteLine(contador);}
                contadorDivisiones = 0;
                contador++;
            }while (contador <= 100);
        }
    }
}
