using System;

namespace Ejercicio_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Ejercicio 1";

            //Declaración de variables a usar.
            string[] estudiantes = new string[5];
            double[,] notas = new double[5, 5];
            double[] prom = new double[5];

            int e = estudiantes.Length;
            for (int i = 0; i < e; i++)
            {
                int nom = i + 1;
                Console.WriteLine($"\nEstudiante #{nom}");
                Console.WriteLine($"\nDigitar el nombre del estudiante \n");
                estudiantes[i] = Console.ReadLine();
                for (int j = 0; j < e; j++)
                {
                    int not = j + 1;
                    Console.WriteLine($"\nDigitar la nota #{not}");
                    notas[i, j] = Double.Parse(Console.ReadLine());

                    if (notas[i, j] < 0 || notas[i, j] > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        j--;
                        Console.WriteLine($"\nNo se permiten numeros negativos, solo numeros en el rango de (0 a 10).");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                prom[i] = promedio(notas[i, 0], notas[i, 1], notas[i, 2], notas[i, 3], notas[i, 4]);

            }

            double max = prom[0], min = prom[0];
            for (int i = 0; i < prom.GetLength(0); i++)
            {
                if (prom[i] > max)
                {
                    max = prom[i];
                }
                if (prom[i] < min)
                {
                    min = prom[i];
                }
            }
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n__________________________");
                Console.WriteLine($"\nAlumno: {estudiantes[i]}.");
                Console.WriteLine($"\nPromedio: {prom[i]}");
                if (prom[i] == max)
                {
                    Console.WriteLine($"\n-->(Mayor promedio)");
                }
                if (prom[i] == min)
                {
                    Console.WriteLine($"\n-->(Menor promedio)");
                }

                if (prom[i] >= 7)
                {
                    Console.WriteLine($"\n-->(Aprobado)");
                }
                if (prom[i] >= 4 && prom[i] < 7)
                {
                    Console.WriteLine($"\n-->(Regular)");
                }
                if (prom[i] < 4)
                {
                    Console.WriteLine($"\n-->(Reprobado)");
                }
                Console.WriteLine($"\n__________________________");

            }


            Console.ReadKey();
        }
        static Double promedio(double n1 = 0, double n2 = 0, double n3 = 0, double n4 = 0, double n5 = 0)
        {
            double prom;
            prom = (n1 + n2 + n3 + n4 + n5) / 5;

            return prom;
        }
    }
}

