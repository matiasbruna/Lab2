using System;

namespace Resolucion_Parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            bool booleano = false;
            int opcion;
            string[] vector = new string[10];
            string elemento;
            int cantidadDeGuionesBajos = int.MinValue;

            do
            {


                do
                {
                    Console.WriteLine("1. Agregar elemento al vector \n2. Mostrar detalles \n9. Salir");
                    booleano = int.TryParse(Console.ReadLine(), out opcion);
                } while (opcion != 1 && opcion != 2 && opcion != 9);

                if (opcion == 9)
                {
                    Console.WriteLine("el programa se cerrara");
                    System.Environment.Exit(-1);
                }

                if (opcion == 1)
                {
                    if (contador >= 10)
                    {
                        Console.WriteLine("el vector esta lleno, pulse una tecla para continuar");
                        Console.ReadKey();
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("ingrese un elemento");
                            elemento = Console.ReadLine();
                            if (elemento.Trim() == "")
                            {
                                Console.WriteLine("el elemento no puede contener vacio");
                            }
                            else
                            {
                                vector[contador] = elemento;
                                contador++;
                            }

                        } while (elemento.Trim() == "");

                    }


                }

                if (opcion == 2)
                {
                    if (contador == 0)
                    {
                        Console.WriteLine("el vector no contiene elementos, presione una tecla para continuar");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("vector en mayusculas");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i].ToUpper());
                        }
                        Console.WriteLine("presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        foreach (string item in vector)
                        {
                            if (item.Length > cantidadDeGuionesBajos)
                            {
                                cantidadDeGuionesBajos = item.Length;
                            }
                        }

                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i].PadRight(cantidadDeGuionesBajos, '_'));
                        }

                        Console.WriteLine("presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        foreach (string item in vector)
                        {
                            Console.WriteLine(item + item.Length);
                        }

                        Array.Sort(vector,(x,y) => x.Length.CompareTo(y.Length));
                        foreach (string item in vector)
                        {
                            Console.WriteLine("{0}, <{1}>", item, (item.Length).ToString());
                        }
                    }
                }

                Console.WriteLine("desea realizar otra accion)1.Si, 2.No");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (opcion == 1);

        }
    }
}