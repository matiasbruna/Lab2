using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_string_ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string[] datos =  {"Arquitectura, UTN Cordoba",
                               "Diseño grafico, UTN Santa Fe",
                               "Diseño industrial, UTN Cordoba",
                               "Administracion de empresas, UTN Santa Fe",
                               "Contador, UTN San Francisco",
                               "Turismo, UTN Buenos Aires",
                               "Medicina, UTN Cordoba",
                               "Quimica, UTN Mendoza",
                               "Historia, UTN La Plata",
                               "Ingenieria electronica, UTN San Francisco",
                               "Ingenieria mecanica, UTN San Francisco",
                               "Ingenieria en sistemas, UTN San Francisco"};

            do
            {
                Console.Write("Escriba carrera o localidad: ");
                string ingreso = Console.ReadLine().ToLower().Trim();

                Console.WriteLine("Carreras que coinciden: ");
                for (int i = 0; i < datos.Count(); i++)
                {
                    if (datos[i].ToLower().StartsWith(ingreso)) Console.WriteLine(datos[i]);
                }

                Console.WriteLine("");

                Console.WriteLine("Localidades que coinciden: ");
                for (int i = 0; i < datos.Count(); i++)
                {
                    if (datos[i].ToLower().EndsWith(ingreso)) Console.WriteLine(datos[i]);
                }

                Console.WriteLine("");

                Console.WriteLine("Desea hacer otra busqueda: si o no");
                ingreso = Console.ReadLine();
                Console.Clear();
                if (ingreso.StartsWith("no")) salir = true;

            } while (salir == false);
        }
    }
}
