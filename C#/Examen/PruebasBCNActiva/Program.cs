// C#
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        int max;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");

            // 1 cambiar el tamaño del array a 10 y meter 10 notas en vez 5
            var notasDeAlumnos = new double[10];                
            for(int i = 0; i < notasDeAlumnos.Length; i++)
            {
                notasDeAlumnos[i]=GetRandomNumber(0, 10);
            }
            foreach (var item in notasDeAlumnos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(Environment.NewLine);

            // 2 ajustar la media
            var suma=0.00;
            for (int i = 0; i < notasDeAlumnos.Length; i++)
            {
                suma = suma + notasDeAlumnos[i];
            }
            
            var media = suma / notasDeAlumnos.Length;
            Console.WriteLine($"la media es {media}");

            // 3 extraer la nota más alta del array y enseñarla en pantalla
            Console.WriteLine("Nota Maxima "+ notasDeAlumnos.Max());
            var max = 0.00;
            for (int i = 0; i < notasDeAlumnos.Length; i++)
            {
                if (notasDeAlumnos[i] > max)
                {
                    max = notasDeAlumnos[i];
                }
            }
            Console.WriteLine("Nota Maxima sin Linq " + max);

            // 4 extraer la nota más baja del array y enseñarña en pantalla
            Console.WriteLine("Nota Minima  " + notasDeAlumnos.Min());

            var min = 10.00;
            for (int i = 0; i < notasDeAlumnos.Length; i++)
            {
                if (notasDeAlumnos[i] < min)
                {
                    min = notasDeAlumnos[i];
                }
            }
            Console.WriteLine("Nota Minima sin Linq " + min);
        }
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}