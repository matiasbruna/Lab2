using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            char[] arrayDeChars;
            int contadorEnteros = 0;
            int contadorChar = 0;
            int contadorOtros = 0;
            int opcion = -1;
            bool boleano;
            string texto = null;
            StringBuilder parrafo = new StringBuilder();
            do
            {

                do
                {
                    Console.WriteLine("10- Ingresar Texto\n20 - Mostrar Info del Texto\n0 - Salir");
                    boleano = int.TryParse(Console.ReadLine(), out opcion);

                } while (opcion != 10 && opcion != 20 && opcion != 0);

                if (opcion == 0)
                {
                    System.Environment.Exit(-1);
                }

                if (opcion == 10)
                {
                    Console.Clear();
                    Console.WriteLine("ingrese un texto");
                    texto = Console.ReadLine();
                    while (texto.Trim() == "" || texto.Length < 35)
                    {
                        if (texto.Trim() == "")
                        {
                            Console.WriteLine("ERROR: el texto no puede estar vacio, presione una tecla");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("ingrese un texto");
                            texto = Console.ReadLine();

                        }

                        if (texto.Length < 25)
                        {
                            Console.WriteLine("ERROR: el texto no puede contener menos de 25 letras, presione una tecla");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("ingrese un texto");
                            texto = Console.ReadLine();
                        }
                    }
                }

                if (opcion == 20)
                {
                    if (texto == null)
                    {
                        Console.WriteLine("ERROR: no se ha ingresado ningun texto, presione una tecla");
                        Console.ReadKey();
                        Console.Clear();                     
                    }
                    else
                    {
                        parrafo.Append(texto);
                        Console.WriteLine(parrafo.Replace(' ', '_'));
                        Console.WriteLine("presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        foreach (char item in texto)
                        {
                            if (char.IsDigit(item))
                            {
                                contadorEnteros++;

                            }
                            if (char.IsLetter(item))
                            {
                                contadorChar++;
                            }
                            if (char.IsPunctuation(item))
                            {
                                contadorOtros++;
                            }
                        }


                        arrayDeChars = new char[contadorChar];

                        foreach (char item in texto)
                        {
                            if (char.IsLetter(item))
                            {
                                arrayDeChars[i] = item;
                                i++;
                            }
                        }


                        Console.WriteLine("Cantidad de numeros: {0}\nCantidad de letras: {1}\nCantidad de otros: {2}", contadorEnteros, contadorChar, contadorOtros);

                        Array.Reverse(arrayDeChars);

                        Console.WriteLine(arrayDeChars);

                    }

                }

                Console.WriteLine("desea realizar otra accion? 1)Si. 2)No.");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcion == 1);

        }
    }
}