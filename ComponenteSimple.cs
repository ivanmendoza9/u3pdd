using System;

namespace PC
{
    class ComponenteSimple : ComponentePC
    {
        private double precio;

        public ComponenteSimple(string nombre, double precio) : base(nombre)
        {
            this.precio = precio;
        }

        public override double ObtenerPrecio()
        {
            return precio;
        }

        public override void Mostrar(string indent = "")
        {
            Console.WriteLine($"{indent}- {Nombre} (${precio})");
        }
    }
}