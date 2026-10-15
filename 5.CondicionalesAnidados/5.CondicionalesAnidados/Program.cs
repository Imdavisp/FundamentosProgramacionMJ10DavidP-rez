using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Anidados
            //b. Diseñar un algoritmo que lea tres números A, B, C y visualice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Se deben ingresar tres valores diferentes");
            Console.WriteLine("Ingrese el primer valor");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                //Verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("El primer número es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer número es el mayor");
                }
            }
            else
            {
                //Falsa
                if (num2 > num3)
                {
                    Console.WriteLine("El segundo número es el mayor");
                }
                else
                {
                    Console.WriteLine("El tercer número es el mayor");
                }
            }


        }
    }
}

