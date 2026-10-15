using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.programacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de Programación");
            MostrarMensaje("Samuel");
            MostrarMensaje("Samuel", "Arango Giraldo");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Procedmientos sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos con parámetros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programación");
        }
        
    }
}
