using System;

namespace _3Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //orden de evaluacion operadores nulericos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3 * 2;

            Console.WriteLine(dato1);

            //operadores logicos
            //conjuncion - and -y -&
            Console.WriteLine("tabla conjunción");
            Console.WriteLine(" V && V = " +(true &&true));
            Console.WriteLine("V && f=" + (true && false));

            //operadores de comparación 
            bool dato6 = 5 < 4;
            bool dato7 = 100==99;
            bool dato10 = 1002 != 102;
            

        }
    }
}
