using System;


namespace TallerCondicionales_DavidPérez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //punto 1


            /*int Numero1 = 0;
            int Numero2 = 0;
            int Numero3 = 0;

            Console.WriteLine("Escriba 3 numeros a continuación.");
            Console.WriteLine("Escriba el primer número:");
            Numero1 = Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("Escriba el segundo número:");
            Numero2 = Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("Escriba el tercer número");
            Numero3 = Convert.ToInt16( Console.ReadLine());

            if (Numero1 == Numero2 || Numero1==Numero3 || Numero2 == Numero3)
            {
                Console.WriteLine("Escriba números distintos");
                
            }
            else
            {
                if (Numero1 < Numero2 && Numero1 < Numero3)
                {
                    if (Numero2 < Numero3)
                        Console.WriteLine("El orden de menor a mayor es: "+Numero1 + " " + Numero2 + " " + Numero3+ " y el número mayor es "+Numero3 );
                    
                    else
                        Console.WriteLine("El orden de menor a mayor es: "+Numero1 + " " + Numero3 + " " + Numero2);
                    Console.WriteLine("El Número mayor es " + Numero2);
                }
                else if (Numero2 < Numero1 && Numero2 < Numero3)
                {
                    if (Numero1 < Numero3)
                        Console.WriteLine("El orden de menor a mayor es: "+Numero2 + " " + Numero1 + " " + Numero3 + " y el número mayor es " + Numero3);
                    else
                        Console.WriteLine("El orden de menor a mayor es: "+Numero2 + " " + Numero3 + " " + Numero1);
                    Console.WriteLine("El Número mayor es " + Numero1);
                }
                else
                {
                    if (Numero1 < Numero2)
                        Console.WriteLine("El orden de menor a mayor es: "+Numero3 + " " + Numero1 + " " + Numero2 + " y el número mayor es " + Numero2);
                    else
                        Console.WriteLine("El orden de menor a mayor es: "+Numero3 + " " + Numero2 + " " + Numero1);
                    Console.WriteLine("El Número mayor es " + Numero1);
                }

            }*/



            //Punto 2
           
                bool invencible;
                int municion;

                
                Console.Write("El personaje es invencible? (escribe true o false): ");
                invencible = bool.Parse(Console.ReadLine());

                
                Random rnd = new Random();
                municion = rnd.Next(0, 15); 

                Console.WriteLine("Municion obtenida: " + municion);

                if (invencible == true && municion >= 1 && municion <= 10)
                {
                    Console.WriteLine("El personaje esta disparando");
                }
                else
                {
                    Console.WriteLine("Tu personaje no puede disparar");
                }
                Console.ReadKey();
            }
        }
    }

