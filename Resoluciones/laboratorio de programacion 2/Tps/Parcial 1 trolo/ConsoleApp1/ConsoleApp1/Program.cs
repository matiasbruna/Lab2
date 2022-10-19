using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int[,] numeros;
        private static int[] vectorcolumna;
        static void Main(string[] args)
        {
            bool salida = false;
            bool validar = false;
            while (!validar)
            {
                try
                {

                    Console.Write("*  Ingrese la cantidad de filas de la matriz: ");
                    int filas = int.Parse(Console.ReadLine());
                    Console.Write("*  Ingrese la cantidad de columnas de la matriz: ");
                    int columnas = int.Parse(Console.ReadLine());

                    numeros = new int[filas, columnas];

                    Console.WriteLine("*  EN MEMORIA SE HA CREADO UNA MATRIZ DE ({0}x{1})       *", filas, columnas);
                    Console.WriteLine("*            PRESIONE ENTER PARA CONTINUAR           *");

                    Console.ReadKey();
                    Console.Clear();
                    validar = true;
                }
                catch (FormatException e)
                {
                    Console.Clear();

                    Console.WriteLine("* " + e.Message + " *");
                    Console.WriteLine("*    PRESIONE ENTER PARA VOLVER AL PASO ANTERIOR     *");

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            do
            {

                Console.WriteLine("* A CONTINUACIÓN DEBE CARGAR LOS NÚMEROS EN LA MATRIZ *");
                cargarNumeros();
                sumarcolumnas();
                mostrarVectorFila();
                Console.WriteLine("");
                mostrarVectorFila();
                Console.Write("vector ordenado");
                Array.Sort(vectorcolumna);
                Console.WriteLine("");



                salida = true;
            } while (!salida);
            Console.WriteLine("*       PRESIONE ENTER PARA SALIR DEL SISTEMA        *");
            Console.ReadKey();


        }

        private static int mayorNumeroIngresado()
        {
            int[] j = new int[numeros.GetLongLength(1)];
            int mayorNumero = 0, fil = 0, col = 0;
            int menorNumero = 0;
            for (int filas = 0; filas < numeros.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < numeros.GetLength(1); columnas++)
                {
                    if (numeros[filas, columnas] > mayorNumero)
                    {
                        mayorNumero = numeros[filas, columnas];
                        fil = filas;
                        col = columnas;
                    }
                    if (numeros[filas, columnas] < menorNumero)
                        menorNumero = numeros[filas, columnas];
                    fil = filas;
                    col = columnas;
                }
            }
            Console.WriteLine("El numero mayor se encuentra en la posición: ({0},{1})", fil, col);
            return mayorNumero;
            Console.WriteLine("El numero menor se encuentra en la posición: ({0},{1})", fil, col);
            return menorNumero;
        }
        private static void cargarNumeros()
        {
            bool validar = false;
            for (int filas = 0; filas < numeros.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < numeros.GetLength(1); columnas++)
                {
                    while (!validar)
                    {
                        try
                        {
                            Console.Write("Ingrese un número en la posición ({0},{1}): ", filas, columnas);
                            numeros[filas, columnas] = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }

            Console.WriteLine("*       DATOS CARGADOS EN LA MATRIZ CORRECTAMENTE     *");
            Console.WriteLine("*    PRESIONE ENTER PARA CONTINUAR CON LA EJECUCIÓN   *");

            Console.ReadKey();
            Console.Clear();
        }



        private static void sumarcolumnas()
        {
            vectorcolumna = new int[numeros.GetLongLength(1)];
            int suma = 0;
            for (int filas = 0; filas < numeros.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < numeros.GetLength(1); columnas++)
                {
                    suma = suma + numeros[columnas, filas];

                }
                vectorcolumna[filas] = suma;
                suma = 0;
            }
        }
        private static void mostrarVectorFila()
        {
            for (int i = 0; i < vectorcolumna.GetLength(0); i++)
            {
                Console.Write(vectorcolumna[i] + " - ");
            }
            Console.WriteLine();
        }
    }
}

