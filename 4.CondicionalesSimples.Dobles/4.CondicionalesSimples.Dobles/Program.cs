using System;


namespace _4.CondicionalesSimples.Dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control condicional
            //condicional simple
            //1.    crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /*  byte edad = 0;
              Console.WriteLine("Ingrese su edad:");
              edad = Convert.ToByte(Console.ReadLine());
              if(edad>=18)
              {
                  Console.WriteLine("bienvenidos a mi pagina");
              }*/


            //crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el suealdo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos 
            /*float sueldo=0;
            string nombre;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo:");
            sueldo= Convert.ToSingle (Console.ReadLine());
            if (sueldo >= 3000) 
            {
                Console.WriteLine("Tu " + nombre + " debes abonar impuestos");  
            }*/


            //crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web" y si es menor que diga q no puede entrar

            /* byte edad = 0;
             Console.WriteLine("Ingrese su edad:");
             edad = Convert.ToByte(Console.ReadLine());
             if (edad >= 18)
             {
                 Console.WriteLine("bienvenidos a mi pagina");
             }
             else
             {
                 Console.WriteLine("No sos apto para el sitio web");
             }*/

            //crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el suealdo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos y si tiene menos de 3000 q no 

            /*float sueldo = 0;
            string nombre;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo >= 3000)
            {
                Console.WriteLine("Tu, " + nombre + ", debes abonar impuestos");
            }
            else
            {
                Console.WriteLine("Tu, " + nombre + ", no debes abonar impuestos");
            }*/

            //Crear un algoritmo que permita ingresar 2 numeros, si el primer numero es mayor al segundo numero informar su suma y diferencia, en caso contrario informar el producto del primer numero respecto al segundo numero 

            float numero1;
            float numero2;
            Console.WriteLine("coloque un numero");
            numero1 =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Coloque otro numero");
            numero2 =Convert.ToSingle(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("su suma es " + (numero1 + numero2) + " y su resta es " + (numero1 - numero2));
            }
            else
            {
                Console.WriteLine("su producto es "+ (numero1*numero2) + " y la division del primero sobre el segundo es " + (numero1/numero2));
            }



        }
    }
}
