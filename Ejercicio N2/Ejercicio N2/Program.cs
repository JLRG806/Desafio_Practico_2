using System;

namespace Ejercicio_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Ejercicio 2";

            //Declaración de variables a usar.
            int[] num = new int[10];
            int m3 = 0, m5 = 0, m = 0;
            int e = num.Length;
            for (int i = 0; i < e; i++)
            {
                int nom = i + 1;
                Console.WriteLine($"\n#{nom}");
                Console.WriteLine($"\nDigitar el numero \n");
                num[i] = Int32.Parse(Console.ReadLine());


                if (num[i] < 0 || num[i] > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    i--;
                    Console.WriteLine($"\nNo se permiten numeros negativos, solo numeros enteros en el rango de (0 a 500).");
                    Console.ForegroundColor = ConsoleColor.Black;
                }

            }

            for (int i = 0; i < e; i++)
            {
                int n = 0;
                if ((num[i] % 3) == 0)
                {
                    m3++;
                    n++;
                }
                if ((num[i] % 5) == 0)
                {
                    m5++;
                    n++;
                }
                if (n == 2)
                {
                    m++;
                }
            }
            Console.WriteLine($"\n______________________________________________");
            Console.WriteLine($"\nCantidad de numeros multiplos de (3): {m3}");
            Console.WriteLine($"\nCantidad de numeros multiplos de (5): {m5}");
            Console.WriteLine($"\nCantidad de numeros multiplos de (3 y 5): {m}");
            Console.WriteLine($"\n______________________________________________");

            Console.ReadKey();
        }
    }
}
