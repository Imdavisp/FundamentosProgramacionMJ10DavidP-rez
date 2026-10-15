using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int secreto = aleatorio.Next(1, 101);
            int intento = 0;

            while (intento != secreto)
            {
                Console.Write("Adivina el numero entre 1 y 100: ");
                intento = int.Parse(Console.ReadLine());

                if (intento > secreto)
                {
                    Console.WriteLine("Demasiado alto, intenta otra vez.");
                }
                else if (intento < secreto)
                {
                    Console.WriteLine("Demasiado bajo, intenta otra vez.");
                }
                else
                {
                    Console.WriteLine("Correcto! Adivinaste el numero.");
                }
            }

            Console.ReadKey();
        }
    }
}
