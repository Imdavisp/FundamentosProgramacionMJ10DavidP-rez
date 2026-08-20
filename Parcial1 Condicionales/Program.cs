using System;


namespace Parcial1_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Pizza = 0;
            string ing1v = "";
            string ing2v = "";
            string ing3v = "";
            string ing1nv = "";
            string ing2nv = "";
            string combingv ="";   //combinacion ingredientes vegetariana
            string combingnv ="";  //combinacion ingredientes no vegetariana
            decimal precioBase = 0;
            decimal porcentajeIva = 0;

            Console.WriteLine("Bienvenidos a Pizzeria olafo");
            Console.WriteLine("Escoge el tipo de pizza escribiendo el número ");
            Console.WriteLine("(1. Vegetariana o 2. No vegetariana)");
            Pizza = Convert.ToInt16(Console.ReadLine());

            if (Pizza == 1)
            {
                Console.WriteLine("Escoge exactamente 3 de los siguientes ingredientes");
                Console.WriteLine("Pimiento\r\nTofu\r\nChampiñones\r\nTomate\r\nLechuga");
                Console.WriteLine("*Los 3 ingredientes deben ser diferentes");
                Console.WriteLine("Escribe aca tu primer ingrediente");
                ing1v = Console.ReadLine();
                Console.WriteLine("escribe aca tu segundo ingrediente");
                ing2v = Console.ReadLine();
                Console.WriteLine("Escribe tu tercer ingrediente");
                ing3v = Console.ReadLine();
                combingv = (ing1v + " y " + ing2v + " y " + ing3v);

                bool Combv1 = (ing1v == "Pimiento" || ing2v == "Pimiento" || ing3v == "Pimiento") &&
                               (ing1v == "Champiñones" || ing2v == "Champiñones" || ing3v == "Champiñones") &&
                               (ing1v == "Lechuga" || ing2v == "Lechuga" || ing3v == "Lechuga");

                bool combv2 = (ing1v == "Tofu" || ing2v == "Tofu" || ing3v == "Tofu") &&
                               (ing1v == "Champiñones" || ing2v == "Champiñones" || ing3v == "Champiñones") &&
                               (ing1v == "Lechuga" || ing2v == "Lechuga" || ing3v == "Lechuga");

                if (Combv1)
                {
                    precioBase = 20000;
                    porcentajeIva = 19;
                }
                else if (combv2)
                {
                    precioBase = 30000;
                    porcentajeIva = 15;
                }
                else
                {
                    precioBase = 25000;
                    porcentajeIva = 10;
                }
            }
            else if (Pizza == 2)
            {
                Console.WriteLine("Escoge exactamente 2 de los siguientes ingredientes");
                Console.WriteLine("Res\r\nChorizo\r\nPollo\r\nTocineta\r\nCerdo");
                Console.WriteLine("*Los 2 ingredientes deben ser diferentes");
                Console.WriteLine("Escribe aca tu primer ingrediente");
                ing1nv = Console.ReadLine();
                Console.WriteLine("escribe aca tu segundo ingrediente");
                ing2nv = Console.ReadLine();
                combingnv = (ing1nv + " y " + ing2nv);

                bool combnv1 = (ing1nv == "Res" || ing2nv == "Res") &&
                               (ing1nv == "Pollo" || ing2nv == "Pollo");

                bool combnv2 = (ing1nv == "Res" || ing2nv == "Res") &&
                               (ing1nv == "Tocineta" || ing2nv == "Tocineta");

                bool combnv3 = (ing1nv == "Chorizo" || ing2nv == "Chorizo") &&
                               (ing1nv == "Tocineta" || ing2nv == "Tocineta");

                if (combnv1)
                {
                    precioBase = 10000;
                    porcentajeIva = 19;
                }
                else if (combnv2)
                {
                    precioBase = 15000;
                    porcentajeIva = 17;
                }
                else if (combnv3)
                {
                    precioBase = 25000;
                    porcentajeIva = 9;
                }
                else
                {
                    precioBase = 22000;
                    porcentajeIva = 10;
                }
            }
            else
            {
                Console.WriteLine("Tipo de pizza no válido.");
            }

            if (Pizza == 1 || Pizza == 2)
            {
                decimal valorIva = precioBase * (porcentajeIva / 100);
                decimal precioFinal = precioBase + valorIva;

                             // factura (Salida del ejercicio)
                Console.WriteLine("\n--- RESUMEN DEL PEDIDO OLAFO ---");
                Console.WriteLine($"Tipo de pizza: " + Pizza);
                Console.WriteLine("*Recuerda que 1=pizza Vegetariana y que 2=Pizza no vegetariana");

                if (Pizza == 1)
                {
                    Console.WriteLine("Ingredientes: " + combingv);
                }
                else
                {
                    Console.WriteLine("Ingredientes: " + combingnv);
                }

                Console.WriteLine("Precio base: " + precioBase);
                Console.WriteLine("IVA: " + porcentajeIva + "%");
                Console.WriteLine("Valor del IVA: " + valorIva);
                Console.WriteLine("Precio final: " + precioFinal);
                Console.WriteLine("Gracias por tu compra en Olafo");
            }



        }
                
            }
            
           

        }
    

