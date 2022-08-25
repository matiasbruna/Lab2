using System;

namespace PruebaTrim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caracter = "1@";
            string nombre1 = "Matias 1@";
            string nombre2 = "1@ Matias";

            Console.Clear();

            Console.WriteLine(nombre2.TrimStart (caracter.ToCharArray()));
            Console.WriteLine(nombre1.TrimEnd (caracter.ToCharArray()));
            
        }
    }
}