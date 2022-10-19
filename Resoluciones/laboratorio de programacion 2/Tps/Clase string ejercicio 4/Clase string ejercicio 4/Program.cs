using System;

namespace Clase_string_ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            string[] palabras;
            string palabra;

            do
            {
                Console.Clear();
                Console.WriteLine("ingrese la cantidad de palabras a ingresar");
            } while (int.TryParse(Console.ReadLine(), out cantidad) == false);

            palabras = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("ingrese la palabra N°{0}", i + 1);
                    palabra = Console.ReadLine();
                } while (palabra == "");
                palabras[i] = palabra;
            }

            int opcion = 0;
            bool ingresocorrecto;
            string letra;

            do
            {
                Console.Clear();
                Console.WriteLine("ingrese el separador: \n1: espacio \n2: punto y coma \n3: guión \n4: asterisco \n5: punto");
                letra = Console.ReadLine();
                ingresocorrecto = int.TryParse(letra, out opcion);
            } while (!ingresocorrecto||opcion>5||opcion<1);

            switch (opcion)
            {
                case 1:
                    letra = " ";
                    break;
                case 2:
                    letra = ";";
                    break;
                case 3:
                    letra = "-";
                    break;
                case 4:
                    letra = "*";
                    break;
                case 5:
                    letra = ".";
                    break;
            }

            Console.Clear();
            Console.WriteLine(string.Join(letra, palabras));

        }
    }
}
