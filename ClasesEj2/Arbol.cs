using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEj2
{
    public class Arbol
    {
        public Nodo raizPrincipal=null;
        int numNodo = 0;
        public void Ingresar(ref Nodo raiz, int num)
        {
            if (raiz == null)
            {
                Nodo nuevo=new Nodo();
                nuevo.dato = num;
                raiz = nuevo;
                numNodo++;
            }
            else
            {
                if (num < raiz.dato)
                {
                    Ingresar(ref raiz.izquierda, num);
                }
                else if (num > raiz.dato)
                {
                    Ingresar(ref raiz.derecha, num);
                }
                else
                {
                    Console.WriteLine("DATO REPETIDO");
                }
            }
        }
        public void Mostrar(Nodo raiz, int espacio)
        {
            if (raiz != null)
            {
                Mostrar(raiz.derecha, espacio+1);
                for (int i = 0; i < espacio; i++)
                {
                    Console.Write("\t");
                }
                Console.WriteLine(raiz.dato);
                Mostrar(raiz.izquierda,espacio+1);
            }
        }
        public void sumaInorden(Nodo raiz, ref int suma)
        {//usar int en ves de void
            if (raiz != null)
            {
                sumaInorden(raiz.izquierda,ref suma);
                suma = suma + raiz.dato;
                sumaInorden(raiz.derecha,ref suma);
            }
            //return:SumaElementos(raiz.izquierda) + raiz.dato +SumaElementos(raiz.derecha);
        }

        public void CantidadNodos(Nodo raiz)
        {
            Console.WriteLine("CANTIDAD DE NODOS: "+numNodo);
        }
        public void MostrarHojas(Nodo raiz, ref int NumHojas)
        {
            if (raiz!=null)
            {
                if (raiz.izquierda==null && raiz.derecha==null)
                {
                    NumHojas++;
                }
                MostrarHojas(raiz.izquierda,ref NumHojas);
                MostrarHojas(raiz.derecha,ref NumHojas);
            }
        }
        public void CantidadRamas(Nodo raiz, ref int ramas)
        {
            if (raiz!=null)
            {
                if (raiz.izquierda!=null)
                {
                    ramas++;
                }
                if (raiz.derecha != null)
                {
                    ramas++;
                }
                CantidadRamas(raiz.izquierda,ref ramas);
                CantidadRamas(raiz.derecha,ref ramas);
            }
        }


    }
}
