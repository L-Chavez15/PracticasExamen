using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEj4
{
    public class ArbolEj5
    {
        public Nodo raizPrincipal=null;
        public void Ingresar(ref Nodo raiz, Destino d)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = d;
                raiz = nuevo;
            }
            else
            {
                if (d.precio < raiz.dato.precio)
                {
                    Ingresar(ref raiz.izquierda, d);
                }
                else if (d.precio > raiz.dato.precio)
                {
                    Ingresar(ref raiz.derecha, d);
                }
                else
                {
                    Console.WriteLine("DATO DUPLICADO");
                }
            }
        }
        public void Mostrar(Nodo raiz)
        {
            if (raiz != null)
            {
                Mostrar(raiz.izquierda);
                Console.WriteLine($"{raiz.dato.lugar} costo $ {raiz.dato.precio}");
                Mostrar(raiz.derecha);
            }
        }
        public void Buscar(Nodo raiz, string nombre, ref int total, ref int tramo)
        {
            /*if (raiz == null)
            {
                Console.WriteLine("DESTINO NO ENCONTRADO");
                return;
            }
            total += raiz.dato.precio;
            tramo++;
            Console.WriteLine("tramo" + tramo + " :" + raiz.dato.lugar + " S/." + raiz.dato.precio);
            if (nombre == raiz.dato.lugar)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("tarifa total : $ " + total);
            }
            else if (nombre.CompareTo(raiz.dato.lugar) < 0)
            {
                //Compareto-->compara dos strings alfabéticamente, igual que un diccionario.
                Buscar(raiz.izquierda, nombre, ref total, ref tramo);
            }
            else
            {
                Buscar(raiz.derecha, nombre, ref total, ref tramo);
            }*/
        }
    }

}
