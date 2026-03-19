using System;

namespace PC
{
    abstract class ComponentePC
    {
        public string Nombre { get; set; }

        public ComponentePC(string nombre)
        {
            Nombre = nombre;
        }

        public abstract double ObtenerPrecio();

        public virtual void Mostrar(string indent = "")
        {
            Console.WriteLine(indent + "- " + Nombre);
        }
    }
}