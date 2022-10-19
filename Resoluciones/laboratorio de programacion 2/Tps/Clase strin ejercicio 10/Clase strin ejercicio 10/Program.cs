using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_strin_ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datos =  {"Gonzalez, Ricardo;ricardogon@gmail.com;35;467987",
                                 "Aima, Lucas;lucas_opt@gmail.com;25;497457",
                                 "Mariano, Andrea;andremari@gmail.com;30;4546788",
                                 "Gutierrez, Manuel;manugu9@gmail.com;23;-",
                                 "Rossi, Marcos;m_rossi@gmail.com;24;476899" };

            char[] delimita = new char[] { ';' };
            string opcionSeleccionada = "";

            do
            {
                // MOSTRAMOS OPCIONES POSIBLES
                Console.WriteLine("Ver datos de: (seleccione nro)");
                for (int i = 0; i < datos.Count(); i++)
                {
                    string[] persona = datos[i].Split(delimita);
                    Console.WriteLine(i.ToString() + ". " + persona[0]);
                }
                Console.WriteLine("\nS _ para salir");

                // SOLICITAMOS INGRESAR LA OPCION
                opcionSeleccionada = Console.ReadLine();
                int opcion;
                bool opcionCorrecta = int.TryParse(opcionSeleccionada, out opcion);
                if (opcionCorrecta && opcion >= 0 && opcion < datos.Count())
                {
                    string[] persona = datos[opcion].Split(delimita);
                    Console.WriteLine("\n DATOS DE: " + persona[0]);
                    Console.WriteLine("Mail: " + persona[1]);
                    Console.WriteLine("Edad: " + persona[2]);
                    Console.WriteLine("Telef: " + persona[3]);
                    Console.ReadKey();
                }
                else
                {
                    if (opcionSeleccionada.ToLower() != "s")
                    {
                        Console.WriteLine("Opcion seleccionada es incorrecta.");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            } while (opcionSeleccionada.ToLower() != "s");
        }

    }
}
