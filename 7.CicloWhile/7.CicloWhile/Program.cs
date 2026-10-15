using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Escribir un algoritmo que permita generar los primeros 5 números enteros positvos y realizar y mostrar su suma.
            /* int contador = 1;
             int acumulador = 0;

             while (contador <= 5)
             {
                 acumulador = acumulador + contador;
                     contador++;
             }
             Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/

            //2. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)
            int contador = 1;
            int acumulador = 1;
            int entrada = 0;

            Console.WriteLine("por favor ingrese el número del que desea obtener su factorial");
            entrada = int.Parse(Console.ReadLine());
            while (contador <= entrada)
            {
                acumulador = acumulador * contador;
                contador++;
            }
            Console.WriteLine($"El factorial de {entrada} es: {acumulador}");

        }
    }
}


