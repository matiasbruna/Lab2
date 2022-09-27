using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Eje9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MiArray = new int[3];
            int opcion = 0;


            do
            {
                Console.Clear();

                opcion = Menu();

                if (opcion == 1)
                {
                    Agregar(MiArray);
                }
                if (opcion == 2)
                {
                    Eliminar(ref MiArray);
                }
                if (opcion == 4)
                {
                    Listar(MiArray);
                }

                // Console.ReadKey();

            } while (opcion != 7);


        }


        static int Menu()
        {
            bool ingresoCorrecto;
            int seleccion;

            do
            {
                Console.Clear();
                Console.WriteLine("1-Añadir un elemento al array");
                Console.WriteLine("2-Eliminar un elemento del array");
                Console.WriteLine("3-Listar el contenido del array");
                Console.WriteLine("4-Listar elementos");
                Console.WriteLine("5- Contar las apariciones de un número en el array");
                Console.WriteLine("6-Calcular la media y el máximo de los elementos del array");
                Console.WriteLine("7-Terminar");
                ingresoCorrecto = int.TryParse(Console.ReadLine(), out seleccion);
            } while (ingresoCorrecto != true || seleccion > 7 || seleccion < 1);
            return seleccion;


        } 

        static void Eliminar (ref int[]A)
        {
            int cont = 0;
            Boolean valida = false;
            int Dato = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    cont++;
                }
            }

            if (cont == A.Length)
            {
                Console.WriteLine("El Elemnto no se puede borra porque el Array esta Vacio.");
                valida = false;
                Console.ReadKey();
            }
            else
            {
                valida = true;
            }

            if (valida)
            {
                Console.WriteLine("Posicion del Elemento que quiere Borrar:");
                Dato = int.Parse(Console.ReadLine());
                A[Dato] = 0;
            }

        }
        
        static int[] Agregar(int[]MiArray)
        {
            int[] A = MiArray;
            int Dato = 0;
            Boolean valida = true;
            int cont = 0;
            Console.Clear();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    cont++;
                }
            }
            if (cont == A.Length - 1)
            {
                valida = false;
            }

            if (valida)
            {
                Console.WriteLine("Ingrese Dato:");
                Dato = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Array LLeno, Borre un elemento del mismo.");
                Console.ReadKey();
            }
           
            if (valida)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == 0)
                    {
                        A[i] = Dato;
                        break;
                    }
                }
            }
            

            return A;
        }
        static void Listar(int[]A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.ReadKey();

        }
    }
}
