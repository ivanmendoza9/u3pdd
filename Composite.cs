using System;
using System.Collections.Generic;

namespace PC
{
    class Composite : ComponentePC
    {
        private List<ComponentePC> componentes = new List<ComponentePC>();

        public Composite(string nombre) : base(nombre) { }

        public void Agregar(ComponentePC componente)
        {
            componentes.Add(componente);
        }

        public override double ObtenerPrecio()
        {
            double total = 0;
            foreach (var comp in componentes)
            {
                total += comp.ObtenerPrecio();
            }
            return total;
        }

        public override void Mostrar(string indent = "")
        {
            Console.WriteLine(indent + "- " + Nombre);
            foreach (var comp in componentes)
            {
                comp.Mostrar(indent + "   ");
            }
        }
    }
}