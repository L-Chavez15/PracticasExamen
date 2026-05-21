using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public Nodo raizPrincipal = null;

        public void Insertar(ref Nodo raiz, int dato)
        {
            if (raizPrincipal == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = dato;

            }
            else
            {
                if (dato < raiz.dato)
                {
                    Insertar(ref raiz.izquierda, dato);
                }
                else if (dato > raiz.dato)
                {
                    Insertar(ref raiz.derecha, dato);
                }
                else
                {
                    Console.WriteLine("DATO REPETIDO"); 
                }
            }
        }
        public void Mostrar(Nodo raiz, int nivel)
        {
            Mostrar(raiz.derecha, nivel+1);
            for (int i = 0; i < nivel; i++)
            {
                Console.Write("   ");
            }
            Mostrar(raiz.izquierda, nivel+1);
        }
        public void Buscar(Nodo raiz, int dato)//ref: muestra los datos originales, no es obligatorio
        {
            if (raiz == null)
            {
                Console.WriteLine("DATO NO ENCONTRADO");
            }
            else
            {
                if (dato < raiz.dato)
                {
                    //izq
                    Buscar(raiz.izquierda, dato);
                }
                else if (dato > raiz.dato)
                {
                    //der
                    Buscar(raiz.derecha, dato);
                }
                else
                {
                    Console.WriteLine("DATO ENCONTRADO");
                }
            }
        }
        public void Eliminar( Nodo raiz, int dato)
        {
            if (raiz == null)
            {
                // 2. Cambiamos el mensaje
                Console.WriteLine("DATO NO ENCONTRADO PARA ELIMINAR");
            }
            else
            {
                if (dato < raiz.dato)
                {
                    // izq (Recuerda agregar "ref" en la llamada recursiva)
                    Eliminar( raiz.izquierda, dato);
                }
                else if (dato > raiz.dato)
                {
                    // der (Recuerda agregar "ref" en la llamada recursiva)
                    Eliminar( raiz.derecha, dato);
                }
                else
                {

                    // Caso A: No tiene hijo izquierdo (esto cubre cuando es hoja o solo tiene hijo derecho)
                    if (raiz.izquierda == null)
                    {
                        raiz = raiz.derecha;
                        Console.WriteLine("DATO ELIMINADO");
                    }
                    // Caso B: No tiene hijo derecho (solo tiene hijo izquierdo)
                    else if (raiz.derecha == null)
                    {
                        raiz = raiz.izquierda;
                        Console.WriteLine("DATO ELIMINADO");
                    }
                    // Caso C: Tiene los dos hijos
                    else
                    {
                        // Buscamos el nodo más a la izquierda de la rama derecha
                        Nodo sucesor = raiz.derecha;
                        while (sucesor.izquierda != null)
                        {
                            sucesor = sucesor.izquierda;
                        }

                        // Copiamos el dato del sucesor al nodo actual
                        raiz.dato = sucesor.dato;

                        // Mandamos a eliminar el sucesor original que ya copiamos
                        Eliminar( raiz.derecha, sucesor.dato);
                    }
                }
            }
        }
    }
}
