using System;

namespace Parcial2_DavidPérez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una institución educativa requiere un programa para procesar el rendimiento académico de los 25 estudiantes del curso de Ciencias Naturales. Por cada estudiante se debe calcular su nota definitiva y determinar si aprobó o reprobó.
Utilizando obligatoriamente una estructura repetitiva, el programa debe:
            Solicitar por teclado las tres calificaciones del período(Examen 1, Examen 2 y Trabajo de Investigación) para cada uno de los 25 estudiantes.Cada nota debe estar entre 0.0 y 5.0.
Calcular el promedio de las tres notas y mostrar en pantalla si el estudiante Aprobó(promedio >= 3.5) o Reprobó.
Al finalizar el procesamiento de todo el curso, el programa debe mostrar un resumen estadístico que incluya:
La cantidad total de estudiantes que aprobaron.
La cantidad total de estudiantes que reprobaron.
El promedio general de todo el curso(el promedio de los promedios de los 25 estudiantes).*/

            int totalEstudiantes = 25;
            int aprobados = 0;
            int reprobados = 0;
            double sumaPromedios = 0.0;

            for (int i = 1; i <= totalEstudiantes; i++)
            {
                double nota1;
                double nota2;
                double nota3;
                double promedio;
            

                Console.WriteLine($"\n Estudiante");
                Console.WriteLine("Porfavor escribir las notas con , (coma) no con . (punto)");
                do
                {
                    Console.Write("Ingrese Examen 1 (de 0.0 a 5.0): ");
                    nota1 = Convert.ToDouble(Console.ReadLine());
                    if (nota1 < 0.0 || nota1 > 5.0)
                    {
                        Console.WriteLine("Nota invalida. Intente de nuevo.");
                    }
                } while (nota1 < 0.0 || nota1 > 5.0);

                do
                {
                    Console.Write("Ingrese Examen 2 (0.0 a 5.0): ");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                    if (nota2 < 0.0 || nota2 > 5.0)
                    {
                        Console.WriteLine("Nota invalida. Intente de nuevo.");
                    }
                } while (nota2 < 0.0 || nota2 > 5.0);

                do
                {
                    Console.Write("Ingrese Trabajo de Investigacion (0.0 a 5.0): ");
                    nota3 = Convert.ToDouble(Console.ReadLine());
                    if (nota3 < 0.0 || nota3 > 5.0)
                    {
                        Console.WriteLine("Nota invalida. Intente de nuevo.");
                    }
                } while (nota3 < 0.0 || nota3 > 5.0);

                promedio = (nota1 + nota2 + nota3) / 3.0;
                sumaPromedios = sumaPromedios + promedio;

                Console.Write($"Promedio: {promedio:F2} - ");

               
                if (promedio >= 3.5)
                {
                    Console.WriteLine("Aprobo");
                    aprobados = aprobados + 1;
                }
                else
                {
                    Console.WriteLine("Reprobo");
                    reprobados = reprobados + 1;
                }
            }


            Console.WriteLine("\n RESUMEN");
            Console.WriteLine($"Estudiantes aprobados:" + aprobados);
            Console.WriteLine($"Estudiantes reprobados: " + reprobados);
            Console.WriteLine($"Promedio general del curso:" + (sumaPromedios / totalEstudiantes));
        }
    }

}

