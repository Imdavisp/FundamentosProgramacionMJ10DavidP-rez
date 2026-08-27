using System;
using System.Reflection;

namespace _8.CiclioWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese el numero a sumar");
            numero=int.Parse(Console.ReadLine());

            while(numero >= 0)
            {
                acumulador += numero;
                Console.WriteLine("Ingrese el numero a sumar");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los numeros ingresados es:{acumulador}");*/
            //Algoritmo que cuente los numeros pares que hay en un rgando de numeros del 1 al n

            int numeron = 0;
            int contador = 1;
            int contadorPares = 0;

            Console.WriteLine("Escribe un numero:");
            numeron = int.Parse(Console.ReadLine());

            while (contador <= numeron)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                    Console.WriteLine($"{contador}-");
                }
                contador++;

            }
            Console.WriteLine($"la cantidad de numeros pares en el rango del 1 al {numeron} es: {contadorPares}");
        }
    }
}
