using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            int cantidad_letras = 0, cantidad_numeros = 0, cantidad_otros = 0, cantidad_palabras = 0,
                palabras_menor_6 = 0, palabras_mayor_9 = 0 ,palabras_entre_6_9 = 0;
            int control;
            string[] palabras;
            bool ingreso_correcto;

            do
            {
                do
                {
                    ingreso_correcto = int.TryParse(Carga("1- Ingresar parrafo \n2- Mostrar info parrafo \n9-salir"), out control);
                } while (!ingreso_correcto ||(control != 1 && control != 2 && control != 9));

                if (control == 1)
                {
                    do
                    {
                        texto = (Carga("Ingrese el texto:"));
                        if (texto.Length < 30)
                        {
                            Console.Clear();
                            Console.WriteLine("El texto ingresado debe superar los 30 caracteres");
                            Console.Read();
                        }
                    } while (texto.Length < 30);
                }
                
                if (control == 2)
                {
                    if (texto != "")
                    {
                        for (int i = 0; i < texto.Length; i++)
                        {
                            if (char.IsLetter(texto[i]))
                            {
                                cantidad_letras++;
                            }
                            if (char.IsDigit(texto[i]))
                            {
                                cantidad_numeros++;
                            }
                            if (!char.IsDigit(texto[1]) && !char.IsLetter(texto[1]))
                            {
                                cantidad_otros++;
                            }
                        }

                        char[] separador = { ' ' };
                        palabras = texto.Split(separador);
                        cantidad_palabras = palabras.Length;
                        Array.Sort(palabras);

                        Console.WriteLine("las palabras en orden alfabetico son:");

                        for (int i = 0; i < palabras.Length; i++)
                        {
                            if (palabras[i].Length < 6)
                            {
                                palabras_menor_6++;
                            }
                            if (palabras[i].Length > 9)
                            {
                                palabras_mayor_9++;
                            }
                            if (palabras[i].Length >= 6 && palabras[i].Length <= 9)
                            {
                                palabras_entre_6_9++;
                            }
                            Console.WriteLine(palabras[i].ToUpper() + ";");

                        }

                        Console.Read();
                        Console.WriteLine("La cantidad de Letras es: " + cantidad_letras);
                        Console.WriteLine("la cantidad de numeros es: " + cantidad_numeros);
                        Console.WriteLine("la cantidad de otros caracteres es: " + cantidad_otros);
                        Console.WriteLine("la cantidad de palabras menores a 6 caracteres es: " + palabras_menor_6);
                        Console.WriteLine("la cantidad de palabras mayores a 9 caracteres es: " + palabras_mayor_9);
                        Console.WriteLine("la cantidad de palabras entre 9 y 6 caracteres es: " + palabras_entre_6_9);


                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Primero se debe ingresar un parrafo");
                        Console.Read();
                    }
                }
                
            } while (control != 9);

 
        }

        static string Carga(string mensaje)
        {
            string ingreso;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
            } while (ingreso == "");
            return ingreso;
        }
    }
}
