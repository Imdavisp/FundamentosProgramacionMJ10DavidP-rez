using System;

namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string iva = "19%";
            string nombre = "David";
            nombre = "Jhon";
            //iva ="20%"; que una constante no se le puede cambiar su valor 

            //Tipos de Datos
            byte dato1 = 255;//de 0 a 255
            int dato2 = -256;//enteros
            ulong dato3 = 2989000;//enteros mas grande
            float dato4 = 5.3f;//decimales pequeños (F AL FINAL SIEMPRE)
            double dato5 = 2123.3265;//decimales mas grandes
            char dato6 = ' ';//almacena un solo caracter
            string dato7 = "lkfuureo899))((//---";//serie de caracteres (frases oraciones etc)
            bool dato8 = false;//true o false
            object dato9 = new object();

            //operadores 
            //numericos
            //cambio de signo 
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato 10: {0}, dato11:{1}, dato12:{2}. dato13:{3}", dato10, dato11, dato12, dato13);
            //aritmeticos
            int dato14 = 5 + 3; //suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//producto
            float dato17 = 5.0f / 3.0f;//division
            Console.WriteLine("suma:{0}, resta:{1}, producto;{2}, division:{3}", dato14, dato15, dato16, dato17);


        }
    }
}
