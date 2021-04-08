using System;

namespace Ejercicio_N3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Ejercicio 3";

            //Declaración de variables a usar.
            string[] sucursales = new string[5];
            double[,] num = new double[5, 2];
            double g = 0, emp = 0;
            for (int i = 0; i < 5; i++)
            {
                int nom = i + 1;
                Console.WriteLine($"\n/**/**/**/**/**/**/**/**/**/**/**/**/**/");
                Console.WriteLine($"\nSucursal #{nom}");
                Console.WriteLine($"\nDigitar el nombre de la sucursal \n");
                sucursales[i] = Console.ReadLine();
                for (int j = 0, k = 1; j < k; j++)
                {
                    Console.WriteLine($"\nDigitar las ganancias ($):");
                    g = Double.Parse(Console.ReadLine());
                    if (g <= 50000 && g >= 1000)
                    {
                             num[i, 0] = g;
                        for (int l = 0, m = 1; l < m; l++)
                        {
                            //x = empleados ingresados adicionales, y = empleados actuales, z = emleados a ingresar.

                            Console.WriteLine($"\n__________________________");
                            Console.WriteLine($"\nNumero de empleados actuales en la sucursal: {num[i, 1]}");
                            Console.WriteLine($"\n__________________________");
                            Console.WriteLine($"\nDigitar el numero de empleados :");
                            emp = Double.Parse(Console.ReadLine());
                            
                            if (emp >= 10)
                            {
                                //-Si el número de empleados en una sucursal supera las 20 personas, el sistema
                                //automáticamente deberá de trasladar a 1 empleado a cada sucursal restante.                                
                                
                                double empleadosSobrantes = 0;

                                num[i, 1] = num[i, 1] + emp;

                                if (num[i, 1] > 20)
                                {
                                    double x = num[i, 1], y = num[i, 1];
                                    empleadosSobrantes = x - 20;                                    

                                    num[i, 1] = y - empleadosSobrantes;
                                    int o = 5,p = i + 1;
                                    //-----------------------//
                                    for (int n = p; n <= o; n++)
                                    {
                                        if (n == 5)
                                        {
                                            if (num[0, 1] == 20 && num[1, 1] == 20 && num[2, 1] == 20 && num[3, 1] == 20 && num[4, 1] == 20)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine($"\nTodas las sucursales ya tienen 20 empleados, ¡No se pueden ingresar mas!");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine($"a");
                                            }
                                            else
                                            {
                                                n = -1;
                                                Console.WriteLine($"b");
                                            }
                                        }
                                        else
                                        {
                                            if (num[n, 1] < 20)
                                            {
                                                num[n, 1]++;
                                                empleadosSobrantes--;
                                                if (empleadosSobrantes == 0)
                                                {
                                                    o = -1;
                                                }
                                                int q = n + 1;
                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                Console.WriteLine($"-->Reparto de empleados: Sucursal #{ q }, cantidad de empleados {num[n, 1] }, Empleados sobrantes " + empleadosSobrantes );
                                                Console.ForegroundColor = ConsoleColor.Black;
                                            }                                            
                                        }                                                                             
                                    }
                                }

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                m++;
                                Console.WriteLine($"\nNo se permiten menos de 10 empleados por sucursal (Max.20).");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        k++;
                        Console.WriteLine($"\nNo se permiten numeros negativos, solo numeros en el rango de ($1,000 a $50,000).");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
            }
            Console.Clear();
            int a = 0, b = 0;
            for (int i = 0; i < 5; i++)
            {
                
                if (num[i, 0] >= 1000 && num[i, 0]<=25000)
                {
                    a++;
                }
                if (num[i, 0] > 25000)
                {
                    b++;
                }

            }
            Console.WriteLine($"\n///////////////////////////////////////////////////////////////////////");
            Console.WriteLine($"\nSucursales que obtienen ganancias entre $1,000 y $25,000 son: {a}.");
            for (int i = 0; i < 5; i++)
            {
                
                if (num[i, 0] >= 1000 && num[i, 0] <= 25000)
                {
                    Console.WriteLine($"\n__________________________________________");
                    Console.WriteLine($"\nNombre Sucursal: {sucursales[i]}.");
                    Console.WriteLine($"\nGanancias: ${num[i, 0]} (Regular).");
                    Console.WriteLine($"\nEmpleados: {num[i, 1]}");

                    
                }

            }
            Console.WriteLine($"\n///////////////////////////////////////////////////////////////////////");
            Console.WriteLine($"\nSucursales que obtienen ganancias mayores de $25,000 son: {b}.");
            for (int i = 0; i < 5; i++)
            {
                if (num[i, 0] >25000)
                {
                    if (num[i, 0] < 30000)
                    {
                        Console.WriteLine($"\n__________________________________________");
                        Console.WriteLine($"\nNombre Sucursal: {sucursales[i]}.");
                        Console.WriteLine($"\nGanancias: ${num[i, 0]} (Regular).");
                        Console.WriteLine($"\nEmpleados: {num[i, 1]}");
                    }
                    else
                    {
                        Console.WriteLine($"\n__________________________________________");
                        Console.WriteLine($"\nNombre Sucursal: {sucursales[i]}.");
                        Console.WriteLine($"\nGanancias: ${num[i, 0]} (Bien Hecho).");
                        Console.WriteLine($"\nEmpleados: {num[i, 1]}");
                    }
                }
            }

            double gT = (num[0, 0] + num[1, 0] + num[2, 0] + num[3, 0] + num[4, 0] );
            Console.WriteLine($"\n__________________________________________");
            Console.WriteLine($"\nGanancias totales de la empresa: ${gT}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n{num[0, 1] }");
            Console.WriteLine($"\n{num[1, 1] }");
            Console.WriteLine($"\n{num[2, 1] }");
            Console.WriteLine($"\n{num[3, 1] }");
            Console.WriteLine($"\n{num[4, 1] }");

            Console.WriteLine($"\n{num[0, 0] }");
            Console.WriteLine($"\n{num[1, 0] }");
            Console.WriteLine($"\n{num[2, 0] }");
            Console.WriteLine($"\n{num[3, 0] }");
            Console.WriteLine($"\n{num[4, 0] }");

        }
    }
}
