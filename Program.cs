using System;

namespace PC
{
    class Program
    {
        static void Main()
        {
            Composite pc = new Composite("PC Gamer");

            Composite internos = new Composite("Componentes Internos");
            Composite refrigeracion = new Composite("Refrigeración");
            Composite perifericos = new Composite("Periféricos");

            Console.WriteLine("pc store");

            //se clasifican los componentes internos
            internos.Agregar(Seleccion("cpu", 100, 200, 400));
            internos.Agregar(Seleccion("gpu", 150, 300, 700));
            internos.Agregar(Seleccion("ram", 50, 100, 200));
            internos.Agregar(Seleccion("motherb", 80, 150, 300));
            internos.Agregar(Seleccion("almacenamiento", 80, 150, 250));
            internos.Agregar(Seleccion("fuente de poder", 60, 120, 220));
            internos.Agregar(Seleccion("gabinete", 50, 100, 200));

            //una pc lleva refrigeracion como disipador y ventiladores
            refrigeracion.Agregar(Seleccion("disipador cpu", 30, 80, 150));

            Console.WriteLine("\n¿cuantos ventiladores deseas? (1-5):");
            int fans = LeerNumero(1, 5);

            for (int i = 0; i < fans; i++)
            {
                refrigeracion.Agregar(Seleccion($"ventilador #{i + 1}", 10, 25, 50));
            }

            //se clasifican los perifericos
            perifericos.Agregar(Seleccion("monitor", 150, 300, 600));
            perifericos.Agregar(Seleccion("teclado", 30, 80, 150));
            perifericos.Agregar(Seleccion("mouse", 20, 60, 120));
            perifericos.Agregar(Seleccion("audifonos", 40, 100, 200));

            //proceso de ensamble
            pc.Agregar(internos);
            pc.Agregar(refrigeracion);
            pc.Agregar(perifericos);

            //despliega un desglose de el total 
            Console.WriteLine("\ndesglose de componentes");
            pc.Mostrar();

            Console.WriteLine("\ntotal");
            Console.WriteLine($"Precio total: ${pc.ObtenerPrecio()}");

            Console.ReadKey();
        }

        static ComponentePC Seleccion(string nombre, double baja, double media, double alta)
        {
            Console.WriteLine($"\nselecciona {nombre}:");
            Console.WriteLine($"1. baja (${baja})");
            Console.WriteLine($"2. media (${media})");
            Console.WriteLine($"3. alta (${alta})");

            int op = LeerNumero(1, 3);

            if (op == 1) return new ComponenteSimple($"{nombre} baja", baja);
            if (op == 2) return new ComponenteSimple($"{nombre} media", media);
            return new ComponenteSimple($"{nombre} alta", alta);
        }

        static int LeerNumero(int min, int max)
        {
            int num;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out num) && num >= min && num <= max)
                    return num;

                Console.WriteLine($"ingresa un num valido ({min}-{max}):");
            }
        }
    }
}