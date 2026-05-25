using ClasesEj4;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolEj5 arbEj5 = new ArbolEj5();
            Destino d1 = new Destino(); 
            d1.lugar = "cajamarca"; d1.precio = 35;
            Destino d2 = new Destino(); 
            d2.lugar = "lima"; d2.precio = 42;
            Destino d3 = new Destino(); 
            d3.lugar = "trujillo"; d3.precio = 30;
            Destino d4 = new Destino(); 
            d4.lugar = "cusco"; d4.precio = 60;
            Destino d5 = new Destino(); 
            d5.lugar = "chimbote"; d5.precio = 37;
            Destino d6 = new Destino(); 
            d6.lugar = "piura"; d6.precio = 28;

            arbEj5.Ingresar(ref arbEj5.raizPrincipal, d1);
            arbEj5.Ingresar(ref arbEj5.raizPrincipal, d2);
            arbEj5.Ingresar(ref arbEj5.raizPrincipal, d3);
            arbEj5.Ingresar(ref arbEj5.raizPrincipal, d4);
            arbEj5.Ingresar(ref arbEj5.raizPrincipal, d5);
            arbEj5.Ingresar(ref arbEj5.raizPrincipal, d6);

            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n:::DESTINOS DISPONIBLES :::");
                Console.WriteLine("----------------------------------------");
                arbEj5.Mostrar(arbEj5.raizPrincipal);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1. Buscar ruta a destino:");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("ADIOS :D");
                        break;
                    case 1:
                        Console.Write("Ingrese Nombre del destino: ");
                        string destinoBuscado = Console.ReadLine();
                        Console.WriteLine("----------------------------------");
                        int total = 0;
                        int tramo = 0;
                        arbEj5.Buscar(arbEj5.raizPrincipal, destinoBuscado, ref total, ref tramo); break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (op!=0);
        }
    }
}
