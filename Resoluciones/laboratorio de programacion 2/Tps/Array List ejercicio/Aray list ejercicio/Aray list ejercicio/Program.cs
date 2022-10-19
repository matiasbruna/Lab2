using System;
using System.Collections;

namespace Aray_list_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList temperaturas_octubre = new ArrayList(31);
      
            Console.ReadKey();
        }

        static int menu()
        {
            bool ingresocorrecto;
            int seleccion;

            do
            {
                Console.Clear();
                Console.WriteLine("1-Agregar");
                Console.WriteLine("2-Modificar");
                Console.WriteLine("3-Eliminar");
                Console.WriteLine("4-Listar elementos");
                Console.WriteLine("5-Reiniciar los valores");
                Console.WriteLine("6-Salir");
                ingresocorrecto = int.TryParse(Console.ReadLine(), out seleccion);
            } while (ingresocorrecto != true || seleccion > 6 || seleccion < 1);
            return seleccion;
        }
        static void agregar(ArrayList temperaturas_octubre)
        {
            int temperatura;
            if (temperaturas_octubre.Count != temperaturas_octubre.Capacity)
            {
                for (int i = 0; i < temperaturas_octubre.Count; i++)
                {
                    Console.Clear();
                    Console.WriteLine("ingrese la temperatura media del dia {0} de 31", i + 1);
                    temperatura = ingreso();
                    temperaturas_octubre.Add(temperatura);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("la lista esta llena");
            }
        }

        static int ingreso()
        {
            int temperatura;
            bool ingresocorrecto;

            do
            {
                ingresocorrecto = int.TryParse(Console.ReadLine(), out temperatura);
            } while (!ingresocorrecto);

            return temperatura;
        }

        static void eliminar (ArrayList temperaturas_octubre)
        {
            int fecha, opcion, temperatura;
            bool ingresocorrecto = true;
            if (temperaturas_octubre.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("1- eliminar por fecha \n 2-eliminar por temperatura");
                opcion = int.Parse(Console.ReadLine());
                if(opcion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el dia de octubre (del 1 al 31) del que desea eliminar la temperatura");
                    fecha = ingreso();
                    do
                    {
                        if (temperaturas_octubre[fecha] != null)
                        {
                            temperaturas_octubre.RemoveAt(fecha);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No se ha ingresado temperatura media en esta fecha");
                            ingresocorrecto = false;
                        }
                    } while (ingresocorrecto == false);
                }
                
                if (opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese la temperatura que desea eliminar (se eliminaran todas las menciones de esa temperatura");
                    temperatura = ingreso();
                    


                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("la lista esta Vacia");
            }
           
        }
    }
}
