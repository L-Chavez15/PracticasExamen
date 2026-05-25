using System;
using System.Data;

namespace ClasesEJ3
{
    public class Persona
    {
        public int codigo;
        public string nombre;
        public int edad;

        public Persona()
        {
            //construye objetos de tipo caja
            //generamos un random dentro del código
            Random r = new Random();
            this.codigo = r.Next(1000, 10000);
        }
        public override string ToString()
        {
            return $"CODIGO: {codigo}"+$"NOMBRE: {nombre}"+$"EDAD: {edad}";
        }
    }
}