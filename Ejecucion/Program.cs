using ClasesEJ3;
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
            Arbol arb3= new Arbol();
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------");
                Console.WriteLine("1.ingresar");
                Console.WriteLine("2.mostrar");
                Console.WriteLine("3.buscar");
                Console.Write("INGRESE UNA OPCION: ");
                op=int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------");

                switch (op)
                {
                    case 0:
                        Console.WriteLine("ADIOS");
                        break;
                    case 1:
                        Persona p = new Persona();
                        Console.WriteLine("CODIGO: "+p.codigo);
                        Console.Write("INGRESE SU NOMBRE: ");
                        p.nombre = Console.ReadLine();
                        Console.Write("INGRESE SU EDAD: ");
                        p.edad = int.Parse(Console.ReadLine());
                        arb3.Ingresar(ref arb3.raizPrincipal, p);
                        break;
                    case 2:
                        Console.WriteLine("******ARBOL FAMILIAR******");
                        arb3.Mostrar(arb3.raizPrincipal, 0);
                        break;
                    case 3:
                        Console.WriteLine("******BUSQUEDA******");
                        int bus;
                        Console.WriteLine("Ingrese código: ");
                        bus = int.Parse(Console.ReadLine());
                        arb3.Buscar(ref arb3.raizPrincipal, bus);
                        break;
                    default:
                        Console.WriteLine("ingrese un opcion valida");
                        break;
                }

                Console.ReadKey();
            } while (op!=0);
        }
    }
}
