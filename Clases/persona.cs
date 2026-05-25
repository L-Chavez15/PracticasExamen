namespace Clases
{
    //ejercicio 1
    public class persona
    {
        public int edad;
        public string nombre;
        public string apellidos;

        public override string ToString()
        {
            return $"EDAD: {edad}"+$"NOMBRE: {nombre}"+"\n"+$"APELLIDOS: {apellidos}"+"\n";
        }
    }
}