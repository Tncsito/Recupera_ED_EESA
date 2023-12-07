using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionG_ED_EESA_Erick.Arreglos
{
    public class Datos
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public string[] Productos = new string[10];
        public int[] Precios = new int[10];
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public void Inicio()
        {
            Console.WriteLine("Bienvendo al inventario de un mercado!");
            Console.WriteLine("Para empezar registremos el primer producto:");

            Console.Write("Producto 1: "); Productos[0] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Precio: "); Precios[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfecto, registraste el producto al inventario");
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public void Registro()
        {
            for (int i = 1; i < Productos.Length; i++)
            {
                Console.Write($"Producto {i + 1}: "); Productos[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Precio: "); Precios[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("/////////////////////////");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public void Menu()
        {
            Inicio();
            bool z = true;

            while (z == true)
            {
                Console.WriteLine("quieres seguir registrando mas? (S/N)");
                char res = Convert.ToChar(Console.ReadLine());
                if (res == 'S')
                {
                    Console.WriteLine("Perfecto, ahora empecemos a registrar!");
                    Console.WriteLine("vamos a registrar 9 productos mas:");

                    Registro();
                    MostrarProductos();

                    Console.WriteLine("\nListo, hemos terminado el registro, ahora que quieres hacer?");
                    Console.WriteLine("1) Ordenar inventario.");
                    Console.WriteLine("2) Buscar inventario.");
                    Console.WriteLine("3) Salir.");

                    int respuesta = Convert.ToInt32(Console.ReadLine());

                    if (respuesta == 1)
                    {
                        Console.WriteLine("Transladando a Ordenamiento: ");
                        Ordenamiento();
                    } 
                    else if(respuesta == 2)
                    {
                        Console.WriteLine("Transladando a Busqueda: ");
                        Busqueda();
                    }
                    else
                    {
                        Console.WriteLine("Saliendo...");
                        z = false;
                    }

                    z = false;
                } else if (res == 'N')
                {
                    Console.WriteLine("Está bien, Hasta la Proxima!");
                    z = false;
                }
                else
                {
                    if (res == 's')
                    {
                        Console.WriteLine("Perfecto, ahora empecemos a registrar!");
                        Console.WriteLine("vamos a registrar 9 productos mas:");

                        Registro();
                        MostrarProductos();

                        Console.WriteLine("\nListo, hemos terminado el registro, ahora que quieres hacer?");
                        Console.WriteLine("1) Ordenar inventario.");
                        Console.WriteLine("2) Buscar inventario.");
                        Console.WriteLine("3) Salir.");

                        int respuesta = Convert.ToInt32(Console.ReadLine());

                        if (respuesta == 1)
                        {
                            Console.WriteLine("Transladando a Ordenamiento: \n");
                            Ordenamiento();
                        }
                        else if (respuesta == 2)
                        {
                            Console.WriteLine("Transladando a Busqueda: ");
                            Busqueda();
                        }
                        else
                        {
                            Console.WriteLine("Saliendo...");
                            z = false;
                        }

                        z = false;
                    }
                    else if (res == 'n')
                    {
                        Console.WriteLine("Está bien, Hasta la Proxima!");
                        z = false;
                    }
                    else
                    {
                        z = false;
                    }
                }
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public void MostrarProductos()
        {
            Console.WriteLine("Los productos son:");
            for (int i = 0; i < Productos.Length; i++)
            {
                Console.Write($"Producto {i + 1}: {Productos[i]}");
                Console.WriteLine("");
                Console.Write($"Precio: {Precios[i]}");
                Console.WriteLine("\n##############################");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public void Ordenamiento() //Ascendente
        {
            int tt = 0;
            int a = 0;
            for (int i = 1; i < Precios.Length; i++)
            {
                a = Precios[tt];
                Precios[tt] = Precios[i - 1];
                Precios[i - 1] = a;
            }

            Console.WriteLine("Ordenamiento realizado, así se miraría el ordenamiento de los precios: ");

            for (int i = 0; i < Productos.Length; i++)
            {
                Console.Write($"Producto {i + 1}: {Productos[i]}");
                Console.WriteLine("");
                Console.Write($"Precio: {Precios[i]}");
                Console.WriteLine("\n##############################");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public void Busqueda()
        {
            int buscar = 0;
            int sentinela = - 1;
            //Se me fue el tiempo :(
        }
    }
}
