using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Carreras =  {"Arquitectura, UTN Cordoba",
                               "Diseno grafico, UTN Santa Fe",
                               "Diseno industrial, UTN Cordoba",
                               "Administracion de empresas, UTN Santa Fe",
                               "Contador, UTN San Francisco",
                               "Turismo, UTN Buenos Aires",
                               "Medicina, UTN Cordoba",
                               "Qu�mica, UTN Mendoza",
                               "Historia, UTN La Plata",
                               "Ingenieria electronica, UTN San Francisco",
                               "Ingenieria mecanica, UTN San Francisco",
                               "Ingenieria en sistemas, UTN San Francisco"};



            Buscar(Carreras);   
        }

        static void Buscar(string[] V)
        {
            Console.Clear();
            string dato = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una carrera o una localidad: ");
                dato = Console.ReadLine();
                for (int i = 0; i < V.Length; i++)
                {
                    if (V[i].StartsWith(dato))
                    {
                        Console.WriteLine(V[i]);
                    }
                }
                for (int i = 0; i < V.Length; i++)
                {
                    if (V[i].EndsWith(dato))
                    {
                        Console.WriteLine(V[i]);
                    }
                }
                Console.ReadKey();
                        
            } while (dato != "s");
            

        }
    }
}
