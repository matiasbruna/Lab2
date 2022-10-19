using System;

namespace Clase_char_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = ' ', ch2;
            char resp = ' ';
            bool ingresocorrecto=false;

            while (!resp.Equals('N'))
            {
                Console.Clear();
                Console.WriteLine("ingrese un caracter");
                ch2 = char.Parse(Console.ReadLine());

                if (!ch1.Equals(' '))
                {
                    Console.WriteLine("el caracter anterior es: " + ch1.ToString());

                    if (ch2.Equals(ch1)) Console.WriteLine("los caracteres ingresados son iguales");
                    if (ch2.CompareTo(ch1) > 0) Console.WriteLine("el caracter ingresado es mayor al anterior");
                    if (ch2.CompareTo(ch1) < 0) Console.WriteLine("el caracter ingresado es menor al anterior");

                    while (!ingresocorrecto)
                    {
                        Console.WriteLine("desea ingresar otro numero? ingrese N para salir");
                        ingresocorrecto = char.TryParse(Console.ReadLine().ToUpper(), out resp);
                    }
                }
                ingresocorrecto = false;
                ch1 = ch2;
            }
        }
    }
}
