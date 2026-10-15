using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Matrices
{
    internal class Program
    {
        static void LlenarMatriz(int[,] matriz, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese el valor: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void TransformarMatriz(int[,] matriz, int filas, int columnas, int N)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < N)
                    {
                        matriz[i, j] = N;
                    }
                }
            }
        }

        static void MostrarMatriz(int[,] matriz, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            LlenarMatriz(matriz, filas, columnas);

            Console.Write("Ingrese el valor umbral N: ");
            int N = int.Parse(Console.ReadLine());

            TransformarMatriz(matriz, filas, columnas, N);

            Console.WriteLine("\nMatriz resultante:");
            MostrarMatriz(matriz, filas, columnas);

            Console.ReadKey();
        }
    }
}
