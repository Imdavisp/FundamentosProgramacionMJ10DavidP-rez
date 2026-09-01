using System;

namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Multiples 
            //Crear un algoritmo que muestre en pantalla un menu de 5 opciones y segun la opcion elegida del menu muestre el mensaje en pantalla con la opion elegida, y si no esta en el menu que muestre error 

            int respuesta = 0;
            Console.WriteLine("------Menú------");
            Console.WriteLine("1.Opción 1     2.Opción 2");
            Console.WriteLine("3.Opción 3     4.Opción 4");
            Console.WriteLine("5.Opción 5 ");
            Console.WriteLine("----------------");
            Console.WriteLine("Elija la opción del menú");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligió la opción 1");
                    break;
                case 2:
                    Console.WriteLine("Eligió la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Eligió la opción 3");
                    break;
                case 4:
                    Console.WriteLine("Eligió la opción 5");
                    break;
                case 5:
                    Console.WriteLine("Eligió la opción 1");
                    break;
                default:
                    Console.WriteLine("Elija una opción valida");
                    break;
            }


        }
    }
}
