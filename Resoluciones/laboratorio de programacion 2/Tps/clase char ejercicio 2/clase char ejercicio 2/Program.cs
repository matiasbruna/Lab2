using System;

namespace clase_char_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter, continuar = 'S';
            bool continuarcorrecto = false;

            while (continuar.Equals('S'))
            {
                Console.Clear();

                Console.WriteLine("ingrese un caracter");
                caracter = char.Parse(Console.ReadLine());
                Console.Clear();

                if (char.IsDigit(caracter) == true)
                {
                    Console.WriteLine((char.GetNumericValue(caracter) + char.GetNumericValue(caracter) * 2));
                }
                if (char.IsLetter(caracter) == true)
                {
                    Console.WriteLine("se ingresó la letra: " + caracter);
                }
                else Console.WriteLine("el caracter es de la categoria: " + char.GetUnicodeCategory(caracter));

                while (!continuarcorrecto)
                {
                    Console.WriteLine("desea continuar? ingrese S para continuar");
                    continuarcorrecto = char.TryParse(Console.ReadLine().ToUpper(), out continuar);
                }

                continuarcorrecto = false;
            }
        }
    }
}
