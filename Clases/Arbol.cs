using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        //ejercicio 1
        public Nodo raizPrincipal = null;
        int numIntegrantes = 0;

        public void Ingresar(ref Nodo raiz, persona p)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = p;
                numIntegrantes++;
                raiz = nuevo;
            }
            else
            {
                if (p.edad < raiz.dato.edad)
                {
                    Ingresar(ref raiz.izquierda, p);
                }
                else if (p.edad > raiz.dato.edad)
                {
                    Ingresar(ref raiz.derecha, p);
                }
                else
                {
                    Console.WriteLine("DATO REPETIDO");
                } 
                    
            }
        }
        public void Mostrar(Nodo raiz, int nivel)
        {
            if (raiz!=null)
            {
                Mostrar(raiz.derecha, nivel + 1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("\t\t\t");
                }
                Console.WriteLine(raiz.dato.edad+"-"+raiz.dato.nombre + "-" +raiz.dato.apellidos);
                Mostrar(raiz.izquierda, nivel + 1);
            }
        }
        public void NumPer()
        {
            Console.WriteLine(numIntegrantes);   
        }
        public void Buscar(Nodo raiz, string dato)//ref: muestra los datos originales, no es obligatorio
        {
            if (raiz != null)
            {
                if (raiz.dato.nombre == dato)
                {
                    Console.WriteLine("PERSONA ENCONTRADA");
                    Console.WriteLine("HIJOS:");

                    if (raiz.izquierda != null)
                    {
                        Console.WriteLine(raiz.izquierda.dato.nombre);
                    }

                    if (raiz.derecha != null)
                    {
                        Console.WriteLine(raiz.derecha.dato.nombre);
                    }
                }

                Buscar(raiz.izquierda, dato);
                Buscar(raiz.derecha, dato);
            }
        }
        /*public void Eliminar( ref Nodo raiz, int dato)
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
                    Eliminar( ref raiz.izquierda, dato);
                }
                else if (dato > raiz.dato)
                {
                    // der (Recuerda agregar "ref" en la llamada recursiva)
                    Eliminar( ref raiz.derecha, dato);
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
                        Eliminar( ref raiz.derecha, sucesor.dato);
                    }
                }
            }*/

    }
}
