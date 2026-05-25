using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEJ3
{
    public  class Arbol
    {
        public Nodo raizPrincipal = null;

        public void Ingresar(ref Nodo raiz, Persona p)
        {
            if (raiz==null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = p;
                raiz = nuevo;
            }
            else
            {
                if (p.codigo<raiz.dato.codigo)
                {
                    Ingresar(ref raiz.derecha,p);
                }
                else if (p.codigo>raiz.dato.codigo)
                {
                    Ingresar(ref raiz.derecha,p);
                }
                else
                {
                    Console.WriteLine("DATO DUPLICADO");
                }
            }
        }
        public void Mostrar(Nodo raiz, int nivel)
        {
            if (raiz != null)
            {
                Mostrar(raiz.derecha, nivel + 1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("\t\t\t");
                }
                Console.WriteLine(raiz.dato.codigo + "-" + raiz.dato.nombre);
                Mostrar(raiz.izquierda, nivel + 1);
            }
        }
        public void Buscar(ref Nodo raiz, int  codigo)
        {
            if (raiz == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DATO NO ENCONTRADO");
                Console.ResetColor();
            }
            else
            {
                if (codigo < raiz.dato.codigo)
                {
                    Buscar(ref raiz.derecha, codigo);
                }
                else if (codigo > raiz.dato.codigo)
                {
                    Buscar(ref raiz.derecha, codigo);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DATO ENCONTRADO\n");
                    Console.ResetColor();
                    Console.WriteLine("Nombre: " + raiz.dato.nombre);
                    Console.WriteLine("Edad: " + raiz.dato.edad);
                }
            }
        }
    }
}
