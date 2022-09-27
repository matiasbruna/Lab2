using System;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            int Opcion;
            String TextoMenu = "1- Ingresar texto \n2- Mostrar informacion del parrafo \n0- Salir";
            bool valida;

            do
            {
                do
                {
               
                   valida = int.TryParse(Menu(TextoMenu), out Opcion);
               
                } while (!valida ||(Opcion != 1 && Opcion != 2  && Opcion != 0));

                if (Opcion == 1)
                {
                    do
                    {
                        texto = (Menu("Ingrese el texto:"));
                        if (texto.Length < 20)
                        {
                            Console.Clear();
                            Console.WriteLine("El texto ingresado debe superar los 20 caracteres");
                            Console.Read();
                        }
                    } while (texto.Length < 20);
                }
                
                if (Opcion == 2)
                {
                    if (texto != "")
                    {
                        Console.Clear();
                        Caracteres(texto);
                        Mostrar(texto);
                        Ordenar(texto);
                        Cantidad(texto);
                        Console.ReadKey();
                    }
                     else
                    {
                      Console.WriteLine("Primero se debe ingresar un parrafo");
                      Console.Read();
                    }
                }
               
                
            } while (Opcion != 0);

 
        }

        static string Menu(string mensaje)
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

        static void Mostrar (string texto)
        {
            int cant_Menores = 0;
            int cant_Mayores = 0;

            string[] palabras;
            char[] Espacio = { ' ', ',','.' };
            palabras = texto.Split(Espacio);
           
               for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].Length < 5)
                    {
                       cant_Menores++;
                    } 
                     if (palabras[i].Length > 9)
                    {
                       cant_Mayores++;
                    } 
                }                    
               
            Console.WriteLine($"La cantidad palabras menores a 5 caracteres son: {cant_Menores}");
            Console.WriteLine($"La cantidad palabras mayores a 9 caracteres son: {cant_Mayores}");
        }
        static void Caracteres(string texto)
        {
            int cant_letras = 0;
            int cant_numeros = 0;
            int cant_otros = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (char.IsLetter(texto[i]))
                {
                    cant_letras++;
                }
                if (char.IsDigit(texto[i]))
                {
                    cant_numeros++;
                }
            } 
            cant_otros = texto.Length - cant_letras - cant_numeros;
            Console.WriteLine("La cantidad de Letras es: " + cant_letras);
            Console.WriteLine("la cantidad de numeros es: " + cant_numeros);
            Console.WriteLine("la cantidad de otros caracteres es: " + cant_otros);

        
        }
        static void Ordenar(string texto)
        {
            string[] palabras;
            char[] Espacio = { ' ', ',','.' };
            palabras = texto.Split(Espacio);
            Array.Sort(palabras);
            Console.WriteLine("\n");
            Console.WriteLine("Todas las palabras ordenadas alfabéticamente con - (guión):");
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] != "")
                {
                 Console.Write($"{palabras[i]}-");
                }
               
            }
            Console.WriteLine("\n");
        }
        static void Cantidad (string texto)
        {
            string[] palabras;
            int cant_palabras = 0;
            char[] Espacio = { ' ', ',','.' };
            palabras = texto.Split(Espacio);
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] != "")
                {
                 cant_palabras++;
                }
               
            }
            Console.WriteLine($"El texto tiene {cant_palabras} palabras.");
        }
    }

}