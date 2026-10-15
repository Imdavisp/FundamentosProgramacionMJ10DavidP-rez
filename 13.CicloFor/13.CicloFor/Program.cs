using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero inicial: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero final: ");
            int fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Los multiplos de 5 son:");

            while (inicio <= fin)
            {
                if (inicio % 5 == 0)
                {
                    Console.WriteLine(inicio);
                }

                inicio++;
            }

            Console.ReadKey();
        }
    }
}
